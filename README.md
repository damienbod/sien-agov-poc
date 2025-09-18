# SIEN AGOV PoC

[![.NET](https://github.com/damienbod/sien-agov-poc/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/sien-agov-poc/actions/workflows/dotnet.yml)

![Architecture](https://github.com/damienbod/sien-agov-poc/blob/main/images/architecture.drawio.png)

## Questions 

- Can we activate OAuth PAR using AGOV?
- Can we use OAuth DPoP tokens?
- Can we request phishing resistant authentication
- Can we use client assertions instead of shared secrets?
- Which client are E-ID claims
- Zero knowledge proofs, how will this be supported => AGOV
- Rough timelime

## LoA with E-ID

urn:qa.agov.ch:names:tc:ac:classes:500 => agov & E-ID

urn:qa.agov.ch:names:tc:ac:classes:600 => Only E-ID only claims E-ID agov (pass through)

## Authentication flow

## Registration flow

- same as authentication flow

### Send 500:

AGOV 

#### Already exist with 300 or less

link to required E-ID

#### User does not exist (500)

Does not work, please create AGOV account first

#### AGOV 600 (pass through)

just works

## Step Up Flow

## Identity check

## LoA definitions

- urn:qa.agov.ch:names:tc:ac:classes:100
- urn:qa.agov.ch:names:tc:ac:classes:200
- urn:qa.agov.ch:names:tc:ac:classes:300
- urn:qa.agov.ch:names:tc:ac:classes:400
- urn:qa.agov.ch:names:tc:ac:classes:500 => request for E-ID identity
- urn:qa.agov.ch:names:tc:ac:classes:600

## AGOV testing

https://trustbroker-idp.agov-epr-lab.azure.adnovum.net/

https://trustbroker.agov-epr-lab.azure.adnovum.net/.well-known/openid-configuration

https://me.agov-epr-lab.azure.adnovum.net/

## Links

- https://swiyu-admin-ch.github.io/
- https://help.agov.ch/?c=login&l=de
- https://www.agov.admin.ch/