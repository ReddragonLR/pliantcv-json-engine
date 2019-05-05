# pliantcv-json-engine
Converts Json to single-page, web-ready CV

## Input: Json
To be defined

## Output: HTML
Single-Page HTML (possibly ReactJS enabled - image carousels, video biographies etc...) that can serve as a digital CV


## JSON Validation
We use an open standard [resume-schema v1.0.0](https://raw.githubusercontent.com/jsonresume/resume-schema/v1.0.0/schema.json) to validate submitted json.

## Tests
Run `dotnet test tests/**`