{ pkgs, pkgs-2411, atomi }:
let

  all = {
    atomipkgs = (
      with atomi;
      {
        inherit
          sg
          pls;
      }
    );
    nix-unstable = (
      with pkgs;
      { }
    );
    nix-2411 = (
      with pkgs-2411;
      {
        yq = yq-go;
        python = python314;
        dotnet = dotnet-sdk_9;
        inherit
          coreutils
          findutils
          gnugrep
          gnused
          jq
          gomplate
          bash
          git
          infisical
          treefmt
          gitlint
          shellcheck
          bun
          go
          richgo

          ;
      }
    );
  };
in
with all;
nix-2411 //
nix-unstable //
atomipkgs
