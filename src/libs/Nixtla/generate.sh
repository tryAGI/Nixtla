dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://raw.githubusercontent.com/Nixtla/nixtla/main/timegpt-docs/openapi.json

# Add top-level security array (spec only has per-operation security)
jq '. + { "security": [{"HTTPBearer": []}] }' openapi.json > openapi_fixed.json
mv openapi_fixed.json openapi.json

autosdk generate openapi.json \
  --namespace Nixtla \
  --clientClassName NixtlaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
