<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="WebClient.Azure" generation="1" functional="0" release="0" Id="dcfdcdcc-0a66-4df6-8f08-8578943a622a" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="WebClient.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="WebClient:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/WebClient.Azure/WebClient.AzureGroup/LB:WebClient:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="WebClient:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/WebClient.Azure/WebClient.AzureGroup/MapWebClient:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WebClientInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/WebClient.Azure/WebClient.AzureGroup/MapWebClientInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:WebClient:Endpoint1">
          <toPorts>
            <inPortMoniker name="/WebClient.Azure/WebClient.AzureGroup/WebClient/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapWebClient:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/WebClient.Azure/WebClient.AzureGroup/WebClient/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWebClientInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/WebClient.Azure/WebClient.AzureGroup/WebClientInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="WebClient" generation="1" functional="0" release="0" software="D:\Education\University\ВКР\Graduate Qualifying Work\WebClient\WebClient.Azure\csx\Debug\roles\WebClient" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WebClient&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;WebClient&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/WebClient.Azure/WebClient.AzureGroup/WebClientInstances" />
            <sCSPolicyUpdateDomainMoniker name="/WebClient.Azure/WebClient.AzureGroup/WebClientUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/WebClient.Azure/WebClient.AzureGroup/WebClientFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="WebClientUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="WebClientFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="WebClientInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="daa1fbed-6a9f-403e-be5f-6407f89d1e23" ref="Microsoft.RedDog.Contract\ServiceContract\WebClient.AzureContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="36a4b83d-98e2-4e10-a19f-a64d64b2832d" ref="Microsoft.RedDog.Contract\Interface\WebClient:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/WebClient.Azure/WebClient.AzureGroup/WebClient:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>