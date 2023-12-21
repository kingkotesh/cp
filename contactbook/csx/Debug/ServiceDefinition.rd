<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" name="contactbook" generation="1" functional="0" release="0" Id="d572fb48-c0ab-44cc-a71e-2ccdde035715" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="contactbookGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="contacts:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/contactbook/contactbookGroup/LB:contacts:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="contacts:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/contactbook/contactbookGroup/Mapcontacts:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="contacts:TableCS" defaultValue="">
          <maps>
            <mapMoniker name="/contactbook/contactbookGroup/Mapcontacts:TableCS" />
          </maps>
        </aCS>
        <aCS name="contactsInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/contactbook/contactbookGroup/MapcontactsInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:contacts:Endpoint1">
          <toPorts>
            <inPortMoniker name="/contactbook/contactbookGroup/contacts/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="Mapcontacts:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/contactbook/contactbookGroup/contacts/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="Mapcontacts:TableCS" kind="Identity">
          <setting>
            <aCSMoniker name="/contactbook/contactbookGroup/contacts/TableCS" />
          </setting>
        </map>
        <map name="MapcontactsInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/contactbook/contactbookGroup/contactsInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="contacts" generation="1" functional="0" release="0" software="C:\ROMAN REIGNS\CP\contactbook\csx\Debug\roles\contacts" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="TableCS" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;contacts&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;contacts&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/contactbook/contactbookGroup/contactsInstances" />
            <sCSPolicyUpdateDomainMoniker name="/contactbook/contactbookGroup/contactsUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/contactbook/contactbookGroup/contactsFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="contactsUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="contactsFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="contactsInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="cb55646c-e429-44db-9682-fd8ec483c1b6" ref="Microsoft.RedDog.Contract\ServiceContract\contactbookContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="b84069e6-4565-4ba3-8739-e722a7a361f5" ref="Microsoft.RedDog.Contract\Interface\contacts:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/contactbook/contactbookGroup/contacts:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>