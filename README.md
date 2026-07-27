# Manage Your Education and Skills Funding Contract Approver Function
The Manage Your Education and Skills Funding Contract Approver Function app is used to allow the following:
 - Reading mesasges from azure service bus topic.
 - Notify FCS of approved contract throught FCS Contract approver API endpoint.

## Provider

[The Department for Education](https://www.gov.uk/government/organisations/department-for-education)

## About this project

This project is a .Net Core 3.1 Azure Function project utilizing an Azure Function App for deployment.

**Note:** The project is currently being updated to be containerised via Docker where the deployment method and target will change, this document will be updated when these changes have been finalised.

# Local Configuration Guide

For running the application locally, `local.settings.json` file need to be created in the `Pds.Contracts.Approver.Func` project. Below, and included in the repo, there is `local.settings.example.json` which can be used as a base and populated with the required values, which can be retrieved from the Azure Portal.

## Application Settings (`local.settings.json`)

```json
{
  "IsEncrypted": false,
  "Values": {
    "AuditApiConfiguration:ApiBaseAddress": "",
    "AuditApiConfiguration:AppUri": "",
    "AuditApiConfiguration:Authority": "",
    "AuditApiConfiguration:ClientId": "",
    "AuditApiConfiguration:ClientSecret": "",
    "AuditApiConfiguration:TenantId": "",
    "AzureWebJobsDashboard": "UseDevelopmentStorage=true",
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "Environment": "local",
    "FcsApiClientConfiguration:ApiBaseAddress": "",
    "FcsApiClientConfiguration:AppUri": "",
    "FcsApiClientConfiguration:Authority": "",
    "FcsApiClientConfiguration:ClientId": "",
    "FcsApiClientConfiguration:ClientSecret": "",
    "FcsApiClientConfiguration:TenantId": "",
    "FcsApiClientConfiguration:ShouldSkipAuthentication": "false",
    "FcsApiClientConfiguration:ApiContractApproverEndpoint": "",
    "FUNCTIONS_EXTENSION_VERSION": "~3",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "HttpPolicyOptions:CircuitBreakerDurationOfBreak": "0.00:00:15",
    "HttpPolicyOptions:CircuitBreakerToleranceCount": "5",
    "HttpPolicyOptions:HttpRetryBackoffPower": "2",
    "HttpPolicyOptions:HttpRetryCount": "3",
    "Pds.Contracts.Approval.Subscription": "",
    "Pds.Contracts.Notifications.Topic": "",
    "PdsApplicationInsights:Environment": "local",
    "PdsApplicationInsights:InstrumentationKey": "",
    "sb-connection-string": ""
  }
}
```
### Setting Details

- **`AuditApiConfiguration:ApiBaseAddress`**  
  The base URL endpoint for Audit API.

- **`AuditApiConfiguration:AppUri`**  
  The unique Application ID URI used as the identifier for the protected Audit API resource within the Identity Provider.

- **`AuditApiConfiguration:Authority`**  
  The base URL of the Identity Provider responsible for authenticating and issuing tokens for the Audit API client.

- **`AuditApiConfiguration:ClientId`**  
  The unique identifier assigned to the admin client application to authenticate its identity against the security provider when calling the Audit API.

- **`AuditApiConfiguration:ClientSecret`**  
  The secret credential used by the Audit client application to securely prove its identity to the Identity Provider.

- **`AuditApiConfiguration:TenantId`**  
  The unique identifier that specifies the exact organization or cloud instance within the Identity Provider where the Audit API client is registered.

- **`AzureWebJobsDashboard`**  
  The core application setting used by the Azure Functions and Azure WebJobs runtime to establish a connection to an Azure Jobs dashboard.

- **`AzureWebJobsStorage`**  
  The core application setting used by the Azure Functions and Azure WebJobs runtime to establish a connection to an Azure Storage account.

- **`Environment`**  
  The environment which the app is running on.

- **`FcsApiClientConfiguration:ApiBaseAddress`**  
  The base URL endpoint for FCS API.

- **`FcsApiClientConfiguration:AppUri`**  
  The unique Application ID URI used as the identifier for the protected FCS API resource within the Identity Provider.

- **`FcsApiClientConfiguration:Authority`**  
  The base URL of the Identity Provider responsible for authenticating and issuing tokens for the FCS API client.

- **`FcsApiClientConfiguration:ClientId`**  
  The unique identifier assigned to the FCS client application to authenticate its identity against the security provider when calling the FCS API.

- **`FcsApiClientConfiguration:ClientSecret`**  
  The secret credential used by the FCS client application to securely prove its identity to the Identity Provider.

- **`FcsApiClientConfiguration:TenantId`**  
  The unique identifier that specifies the exact organization or cloud instance within the Identity Provider where the FCS API client is registered.

- **`FcsApiClientConfiguration:ShouldSkipAuthentication`**
  Flag to set if authentication should be skipped or not.

- **`FcsApiClientConfiguration:ApiContractApproverEndpoint`**  
  Latest page path for FCS API

- **`FUNCTIONS_EXTENSION_VERSION`**  
  The functions extension version number.

- **`FUNCTIONS_WORKER_RUNTIME`**  
  The functions runtime.

- **`HttpPolicyOptions:CircuitBreakerDurationOfBreak`**  
  The duration (typically a `TimeSpan` string) that the circuit breaker remains open, blocking all outgoing HTTP requests, before entering a test state.

- **`HttpPolicyOptions:CircuitBreakerToleranceCount`**  
  The consecutive number of failed HTTP requests or specific status codes allowed before the circuit breaker trips and opens.

- **`HttpPolicyOptions:HttpRetryBackoffPower`**  
  The mathematical exponent or base value used to calculate the exponential delay between consecutive HTTP retry attempts.

- **`HttpPolicyOptions:HttpRetryCount`**  
  The maximum number of retry attempts allowed for a single HTTP request when encountering transient network errors or specific failure status codes.

- **`Pds.Contracts.Approval.Subscription`**  
  Contract Approver sunscription name.

- **`Pds.Contracts.Notifications.Topic`**  
  Contract notification topic name.

- **`PdsApplicationInsights:Environment`**  
  The environment which the app is running on for Application Insights for logging purposes.

- **`PdsApplicationInsights:InstrumentationKey`**  
  The key for Application Insights resource for logging purposes.

- **`sb-connection-string`**  
  The connection string for the Azure Service Bus resource.

## Build and Test

To build and test locally, you can either use Visual Studio, Visual Studio Code or simply use dotnet CLI `dotnet build` and `dotnet test` more information in dotnet CLI can be found at <https://docs.microsoft.com/en-us/dotnet/core/tools/>.

## Contribute

To contribute,

- If you are part of the team then create a branch for changes and then submit your changes for review by creating a pull request.
- If you are external to the organisation then fork this repository and make necessary changes and then submit your changes for review by creating a pull request.