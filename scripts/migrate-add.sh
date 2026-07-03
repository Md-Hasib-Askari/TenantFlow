#!/usr/bin/env bash
set -euo pipefail
cd "$(dirname "$0")/.."

dotnet ef migrations add "$1" \
  --project src/Infrastructure \
  --startup-project src/Api \
  --output-dir Migrations \
  "$@"
