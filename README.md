# Microphone Mute

## Project Development Information

- .NET Version: 7.0 
- C# Version: 11
- Using Git: YES

## Git Branches

- main: For deployment in production server
- development: For develop and tests

### Git Nomenclature

For creating an stardard names this is the structure

- NameLastNameInitial-RequestCode-NameOfBrach

For Example

- AKCM-01-Login

## Folder Administration and Uses

- Model View Controller (MVC) 


## Environments and constants file

**When to use them?**

### Environments

- Use it when need to store variables that changes when go to production and have to be in a secure place, for example: token_secrets, API URLs...

### Constants

- Use it when their value no changes during deployment to production or if its value isn't vulnerable.
