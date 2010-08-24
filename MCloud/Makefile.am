
EXTRA_DIST =  

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG"
ASSEMBLY = bin/Debug/MCloud.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug

DIFFIEHELLMAN_DLL_SOURCE=../lib/DiffieHellman.dll
NEWTONSOFT_JSON_NET20_DLL_SOURCE=../lib/Newtonsoft.Json.Net20.dll
ORG_MENTALIS_SECURITY_DLL_SOURCE=../lib/Org.Mentalis.Security.dll
TAMIR_SHARPSSH_DLL_SOURCE=../lib/Tamir.SharpSSH.dll
AWSSDK_DLL_SOURCE=../lib/AWSSDK.dll
MCLOUD_DLL_MDB_SOURCE=bin/Debug/MCloud.dll.mdb
MCLOUD_DLL_MDB=$(BUILD_DIR)/MCloud.dll.mdb

endif

if ENABLE_DEBUG_MIXED_PLATFORMS
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG"
ASSEMBLY = bin/Debug/MCloud.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug

DIFFIEHELLMAN_DLL_SOURCE=../lib/DiffieHellman.dll
NEWTONSOFT_JSON_NET20_DLL_SOURCE=../lib/Newtonsoft.Json.Net20.dll
ORG_MENTALIS_SECURITY_DLL_SOURCE=../lib/Org.Mentalis.Security.dll
TAMIR_SHARPSSH_DLL_SOURCE=../lib/Tamir.SharpSSH.dll
AWSSDK_DLL_SOURCE=../lib/AWSSDK.dll
MCLOUD_DLL_MDB_SOURCE=bin/Debug/MCloud.dll.mdb
MCLOUD_DLL_MDB=$(BUILD_DIR)/MCloud.dll.mdb

endif

if ENABLE_DEBUG_X86
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG"
ASSEMBLY = bin/Debug/MCloud.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug

DIFFIEHELLMAN_DLL_SOURCE=../lib/DiffieHellman.dll
NEWTONSOFT_JSON_NET20_DLL_SOURCE=../lib/Newtonsoft.Json.Net20.dll
ORG_MENTALIS_SECURITY_DLL_SOURCE=../lib/Org.Mentalis.Security.dll
TAMIR_SHARPSSH_DLL_SOURCE=../lib/Tamir.SharpSSH.dll
AWSSDK_DLL_SOURCE=../lib/AWSSDK.dll
MCLOUD_DLL_MDB_SOURCE=bin/Debug/MCloud.dll.mdb
MCLOUD_DLL_MDB=$(BUILD_DIR)/MCloud.dll.mdb

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize-
ASSEMBLY = bin/Release/MCloud.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release

DIFFIEHELLMAN_DLL_SOURCE=../lib/DiffieHellman.dll
NEWTONSOFT_JSON_NET20_DLL_SOURCE=../lib/Newtonsoft.Json.Net20.dll
ORG_MENTALIS_SECURITY_DLL_SOURCE=../lib/Org.Mentalis.Security.dll
TAMIR_SHARPSSH_DLL_SOURCE=../lib/Tamir.SharpSSH.dll
AWSSDK_DLL_SOURCE=../lib/AWSSDK.dll
MCLOUD_DLL_MDB=

endif

if ENABLE_RELEASE_MIXED_PLATFORMS
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize-
ASSEMBLY = bin/Release/MCloud.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release

DIFFIEHELLMAN_DLL_SOURCE=../lib/DiffieHellman.dll
NEWTONSOFT_JSON_NET20_DLL_SOURCE=../lib/Newtonsoft.Json.Net20.dll
ORG_MENTALIS_SECURITY_DLL_SOURCE=../lib/Org.Mentalis.Security.dll
TAMIR_SHARPSSH_DLL_SOURCE=../lib/Tamir.SharpSSH.dll
AWSSDK_DLL_SOURCE=../lib/AWSSDK.dll
MCLOUD_DLL_MDB=

endif

if ENABLE_RELEASE_X86
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize-
ASSEMBLY = bin/Release/MCloud.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release

DIFFIEHELLMAN_DLL_SOURCE=../lib/DiffieHellman.dll
NEWTONSOFT_JSON_NET20_DLL_SOURCE=../lib/Newtonsoft.Json.Net20.dll
ORG_MENTALIS_SECURITY_DLL_SOURCE=../lib/Org.Mentalis.Security.dll
TAMIR_SHARPSSH_DLL_SOURCE=../lib/Tamir.SharpSSH.dll
AWSSDK_DLL_SOURCE=../lib/AWSSDK.dll
MCLOUD_DLL_MDB=

endif

AL=al2
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(DIFFIEHELLMAN_DLL) \
	$(NEWTONSOFT_JSON_NET20_DLL) \
	$(ORG_MENTALIS_SECURITY_DLL) \
	$(TAMIR_SHARPSSH_DLL) \
	$(AWSSDK_DLL) \
	$(MCLOUD_DLL_MDB)  

LINUX_PKGCONFIG = \
	$(MCLOUD_PC)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

FILES = \
	Model/ServerDriver.cs \
	Model/ServerNode.cs \
	Operation/CreateUser.cs \
	Operation/Deployment.cs \
	Operation/MultiStepDeployment.cs \
	Operation/PushPgsqlDB.cs \
	Operation/PutDirectory.cs \
	Operation/PutFile.cs \
	Operation/PutFiles.cs \
	Operation/PutSSHKeys.cs \
	Operation/RunCommand.cs \
	Operation/RunScript.cs \
	Operation/SSHDeployment.cs \
	Properties/AssemblyInfo.cs \
	Provider/DreamHost/DreamhostAPIException.cs \
	Provider/DreamHost/DreamhostConnection.cs \
	Provider/DreamHost/DreamhostNodeDrive.cs \
	Provider/DreamHost/DreamhostResponse.cs \
	Provider/Dummy/DummyConnection.cs \
	Provider/Dummy/DummyNodeDriver.cs \
	Provider/EC2/EC2APSEConnection.cs \
	Provider/EC2/EC2APSENodeDriver.cs \
	Provider/EC2/EC2Connection.cs \
	Provider/EC2/EC2Driver.cs \
	Provider/EC2/EC2EUConnection.cs \
	Provider/EC2/EC2EUNodeDriver.cs \
	Provider/EC2/EC2Node.cs \
	Provider/EC2/EC2NodeOptions.cs \
	Provider/EC2/EC2NodeSizes.cs \
	Provider/EC2/EC2Response.cs \
	Provider/EC2/EC2USWestConnection.cs \
	Provider/EC2/EC2USWestNodeDriver.cs \
	Provider/EC2/EucConnection.cs \
	Provider/EC2/EucNodeDriver.cs \
	Provider/ECP/ECPConnection.cs \
	Provider/ECP/ECPNodeDriver.cs \
	Provider/ECP/ECPResponse.cs \
	Provider/ElasticHosts/ElasticHostsBaseConnection.cs \
	Provider/ElasticHosts/ElasticHostsBaseNodeDriver.cs \
	Provider/ElasticHosts/ElasticHostsException.cs \
	Provider/ElasticHosts/ElasticHostsNodeSize.cs \
	Provider/ElasticHosts/ElasticHostsResponse.cs \
	Provider/ElasticHosts/ElasticHostsUK1Connection.cs \
	Provider/ElasticHosts/ElasticHostsUK1NodeDriver.cs \
	Provider/ElasticHosts/ElasticHostsUK2Connection.cs \
	Provider/ElasticHosts/ElasticHostsUK2NodeDriver.cs \
	Provider/ElasticHosts/ElasticHostsUS1Connection.cs \
	Provider/ElasticHosts/ElasticHostsUS1NodeDriver.cs \
	Provider/GoGrid/GoGridAPI.cs \
	Provider/GoGrid/GoGridConnection.cs \
	Provider/GoGrid/GoGridNode.cs \
	Provider/GoGrid/GoGridNodeDriver.cs \
	Provider/GoGrid/GoGridNodeOptions.cs \
	Provider/GoGrid/GoGridResponse.cs \
	Provider/IBM_SBC/IBMConnection.cs \
	Provider/IBM_SBC/IBMNodeDriver.cs \
	Provider/IBM_SBC/IBMResponse.cs \
	Provider/Linode/LinodeAPI.cs \
	Provider/Linode/LinodeCertificatePolicy.cs \
	Provider/Linode/LinodeDriver.cs \
	Provider/Linode/LinodeError.cs \
	Provider/Linode/LinodeNode.cs \
	Provider/Linode/LinodeNodeOptions.cs \
	Provider/Linode/LinodeRequest.cs \
	Provider/Linode/LinodeResponse.cs \
	Provider/Linode/PaymentTerm.cs \
	Provider/Model/Entity.cs \
	Provider/Model/Node.cs \
	Provider/Model/NodeAuth.cs \
	Provider/Model/NodeAuthType.cs \
	Provider/Model/NodeDriver.cs \
	Provider/Model/NodeImage.cs \
	Provider/Model/NodeLocation.cs \
	Provider/Model/NodeOptions.cs \
	Provider/Model/NodeProvider.cs \
	Provider/Model/NodeSize.cs \
	Provider/Model/NodeState.cs \
	Provider/OpenNebula/OpenNebualNodeDriver.cs \
	Provider/OpenNebula/OpenNebulaConnection.cs \
	Provider/OpenNebula/OpenNebulaResponse.cs \
	Provider/Rackspace/RackspaceConnection.cs \
	Provider/Rackspace/RackspaceNodeDriver.cs \
	Provider/Rackspace/RackspaceNodeOptions.cs \
	Provider/Rackspace/RackspaceResponse.cs \
	Provider/RimuHosting/RimuHostingConnection.cs \
	Provider/RimuHosting/RimuHostingException.cs \
	Provider/RimuHosting/RimuHostingNodeDriver.cs \
	Provider/RimuHosting/RimuHostingResponse.cs \
	Provider/SliceHost/SlicehostConnection.cs \
	Provider/SliceHost/SlicehostNodeDriver.cs \
	Provider/SliceHost/SlicehostResponse.cs \
	Provider/SoftLayer/SoftLayerConnection.cs \
	Provider/SoftLayer/SoftLayerException.cs \
	Provider/SoftLayer/SoftLayerNodeDriver.cs \
	Provider/SoftLayer/SoftLayerProxy.cs \
	Provider/SoftLayer/SoftLayerSafeTransport.cs \
	Provider/SoftLayer/SoftLayerTransport.cs \
	Provider/vCloud/HostingComConnection.cs \
	Provider/vCloud/HostingComDriver.cs \
	Provider/vCloud/InstantiateVAppXML.cs \
	Provider/vCloud/TerremarkConnection.cs \
	Provider/vCloud/TerremarkDriver.cs \
	Provider/vCloud/VCloudConnection.cs \
	Provider/vCloud/VCloudNodeDriver.cs \
	Provider/vCloud/VCloudResponse.cs \
	Provider/Voxel/VoxelConnection.cs \
	Provider/Voxel/VoxelNodeDriver.cs \
	Provider/Voxel/VoxelResponse.cs \
	Provider/VPSNet/VPSNetConnection.cs \
	Provider/VPSNet/VPSNetNodeDriver.cs \
	Provider/VPSNet/VPSNetResponse.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	mcloud.pc.in 

REFERENCES =  \
	System.Web \
	System.Core \
	System \
	ICSharpCode.SharpZipLib \
	Npgsql

DLL_REFERENCES =  \
	../lib/DiffieHellman.dll \
	../lib/Newtonsoft.Json.Net20.dll \
	../lib/Org.Mentalis.Security.dll \
	../lib/Tamir.SharpSSH.dll \
	../lib/AWSSDK.dll

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

include $(top_srcdir)/Makefile.include

DIFFIEHELLMAN_DLL = $(BUILD_DIR)/DiffieHellman.dll
NEWTONSOFT_JSON_NET20_DLL = $(BUILD_DIR)/Newtonsoft.Json.Net20.dll
ORG_MENTALIS_SECURITY_DLL = $(BUILD_DIR)/Org.Mentalis.Security.dll
TAMIR_SHARPSSH_DLL = $(BUILD_DIR)/Tamir.SharpSSH.dll
AWSSDK_DLL = $(BUILD_DIR)/AWSSDK.dll
MCLOUD_PC = $(BUILD_DIR)/mcloud.pc

$(eval $(call emit-deploy-target,DIFFIEHELLMAN_DLL))
$(eval $(call emit-deploy-target,NEWTONSOFT_JSON_NET20_DLL))
$(eval $(call emit-deploy-target,ORG_MENTALIS_SECURITY_DLL))
$(eval $(call emit-deploy-target,TAMIR_SHARPSSH_DLL))
$(eval $(call emit-deploy-target,AWSSDK_DLL))
$(eval $(call emit-deploy-wrapper,MCLOUD_PC,mcloud.pc))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
