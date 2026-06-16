install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.json https://raw.githubusercontent.com/Nixtla/nixtla/main/timegpt-docs/openapi.json

# Add top-level security array (spec only has per-operation security)
jq '. + { "security": [{"HTTPBearer": []}] }' openapi.json > openapi_fixed.json
mv openapi_fixed.json openapi.json

autosdk generate openapi.json \
  --namespace Nixtla \
  --clientClassName NixtlaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
