# Using the Strand7 API manual with an AI coding agent

The Strand7 R3 API Manual is a ~10 MB PDF shipped with the product at:

```
C:\Program Files\Strand7 R31\Documentation\Strand7 R3 API Manual.pdf
```

This file is **not** redistributed in this repository (it is Strand7 Pty Ltd
copyrighted material). Instead, this project provides a deterministic pipeline
to convert it, *on the developer's own machine*, into agent-friendly chunks
that live under `docs/api/`.

## Why not just ship the PDF?

A monolithic PDF is the worst possible input for an LLM-based coding agent:

- It is binary; tools must OCR/parse it on every read.
- It is far larger than any reasonable context window.
- Headings, function signatures and parameter tables don't survive PDF
  extraction without post-processing.
- It usually cannot be redistributed.

## Recommended pipeline (what this repo does)

1. **Extract text** with [`markitdown`](https://github.com/microsoft/markitdown)
   (`pip install markitdown[pdf]`). On the dev box used to build this project
   the manual converts to a 1.5 MB single markdown file in about 90 seconds.
2. **Split into one file per API function** by intersecting the markdown with
   the actual P/Invoke list extracted from
   `Strand7Sharp/Interop/St7API.cs`. Currently this produces **1916 of 1918**
   `docs/api/St7*.md` pages (the two missing ones are functions that don't have
   their own section heading in the manual).
3. **Inject the first paragraph of each Markdown page as a `<summary>` XML
   doc comment** above the corresponding `[DllImport]` in
   `Strand7Sharp/Interop/St7API.cs` (see `tools/Inject-XmlDocs.ps1`). The
   injector is idempotent — re-run it any time the markdown changes.
4. **Ship the Markdown in the NuGet package** under `docs/api/` (already
   configured in `Strand7Sharp.csproj`). Agents using the package can read the
   files directly out of `~/.nuget/packages/strand7sharp/<version>/docs/api/`.

## What the agent should be told

Give the agent a short rule such as:

> Whenever you need to call a Strand7 API function, first read
> `docs/api/<FunctionName>.md` from the workspace. If it is missing, fall back
> to the XML doc comment on `St7API.St7.<FunctionName>`.

This single rule keeps the prompt small while letting the agent pull in
*exactly* the page it needs, on demand.

## Other options considered

| Approach | Why we didn't pick it |
| --- | --- |
| Drop the whole PDF in the prompt | Will not fit; cannot be redistributed. |
| Vector store / RAG over the PDF | Works, but adds infrastructure; the manual is already function-scoped, so plain file lookup is simpler and reproducible. |
| Convert PDF to a single Markdown file | Still too large for one prompt; harder to grep. |
| Generate Roslyn analyzer with diagnostics from the manual | Overkill for a first release; revisit later. |

Run `pwsh tools/Convert-ApiManual.ps1` after installing Strand7 R3 to populate
`docs/api/` locally.


