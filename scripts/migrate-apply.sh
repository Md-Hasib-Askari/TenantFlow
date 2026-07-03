#!/usr/bin/env bash
set -euo pipefail
cd "$(dirname "$0")/.."

dotnet ef database update \
  --project src/Infrastructure \
  --startup-project src/Api \
  "$@"
