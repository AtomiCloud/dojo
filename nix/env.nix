{ pkgs, packages }:
with packages;
{
  system = [
    coreutils
    findutils
    gnugrep
    gnused
    bash
    jq
    yq
  ];

  dev = [
    pls
    git
  ];

  main = [
    infisical
    bun
    go
    python
    dotnet
    richgo
    gomplate
  ];

  lint = [
    # core
    treefmt
    gitlint
    shellcheck
    sg
  ];

  releaser = [
    sg
  ];
}
