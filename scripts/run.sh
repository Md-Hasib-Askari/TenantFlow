#!/usr/bin/env bash
set -euo pipefail
cd "$(dirname "$0")/.."

if [[ "${1:-}" == "-h" || "${1:-}" == "--help" ]]; then
  echo "Usage: $0 [--seed] [--no-watch] — run the API with hot reload"
  exit 0
fi

ARGS=()
SEED=false
WATCH=true

for arg in "$@"; do
  case "$arg" in
    --seed) SEED=true ;;
    --no-watch) WATCH=false ;;
    *) ARGS+=("$arg") ;;
  esac
done

if $SEED; then
  ARGS+=("-- --seed")
fi

if $WATCH; then
  DOTNET_USE_POLLING_FILE_WATCHER=true dotnet watch --project src/Api "${ARGS[@]}"
else
  dotnet run --project src/Api "${ARGS[@]}"
fi
