# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: NetApp
namespace: Azure.ResourceManager.NetApp
require: https://github.com/Azure/azure-rest-api-specs/blob/8ff7d5ef46f43875262110a4b2df7357bdf4369c/specification/netapp/resource-manager/readme.md
tag: package-netapp-2022-01-01
output-folder: $(this-folder)/Generated
clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

format-by-name-rules:
  'tenantId': 'uuid'
  'ETag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

rename-rules:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4
  Ipv6: IPv6
  Ipsec: IPsec
  SSO: Sso
  URI: Uri
  Etag: ETag

directive:
  - from: NetApp.json
    where: $.definitions..type
    transform: >
      $['x-ms-client-name'] = 'ResourceType';
      $['x-ms-format'] = 'resource-type';
  - from: NetApp.json
    where: $.definitions
    transform: >
      $.volumeQuotaRulesProperties.properties.quotaType['x-ms-enum']['name'] = 'QuotaType';
```