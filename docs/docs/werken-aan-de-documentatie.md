# Setup

Voor het weergeven van de documentatie is gebruikt gemaakt van [MkDocs Material](https://squidfunk.github.io/mkdocs-material/). Uitgebreide instructie voor het gebruiken van MkDocs Material zijn beschikbaar op hun website. Op deze pagina worden een paar handige commands uitgelicht.

Om tijdens het maken en aanpassen van de documentatie de site dynamisch te previewen kan de volgende command gebruikt worden in `keuzewijzer-hbo-deeltijd-ict\docs`.

=== "Windows Command Prompt"
    ```
    docker run --rm -it -p 8000:8000 -v "%cd%":/docs squidfunk/mkdocs-material
    ```
=== "Unix, Powershell"
    ```
    docker run --rm -it -p 8000:8000 -v ${PWD}:/docs squidfunk/mkdocs-material
    ```


Op `http://localhost:8000` is nu een live preview van de documentatie te zien, die automatisch update bij wijzigingen in de bestanden.

Om de website statisch te bouwen moet de volgende command uitgevoerd worden in `keuzewijzer-hbo-deeltijd-ict\docs`.

=== "Windows Command Prompt"
    ```
    docker run --rm -it -v "%cd%":/docs squidfunk/mkdocs-material build
    ```
=== "Unix, Powershell"
    ```
    docker run --rm -it -v ${PWD}:/docs squidfunk/mkdocs-material build
    ```

In de `keuzewijzer-hbo-deeltijd-ict\docs\site` folder wordt de statische website gebouwt. Hier kan zonder een database of server de documentatie bekeken worden.

# Inhoud

In `keuzewijzer-hbo-deeltijd-ict\docs\docs` staan de .md bestanden met alle inhoud van de documentatie.

In `keuzewijzer-hbo-deeltijd-ict\docs\mkdocs.yaml` staat de navigatie van de site.