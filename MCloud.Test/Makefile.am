
EXTRA_DIST =  

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;TRACE"
ASSEMBLY = bin/Debug/MCloud.Test.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug/

MCLOUD_TEST_DLL_MDB_SOURCE=bin/Debug/MCloud.Test.dll.mdb
MCLOUD_TEST_DLL_MDB=$(BUILD_DIR)/MCloud.Test.dll.mdb

endif

if ENABLE_DEBUG_MIXED_PLATFORMS
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;TRACE"
ASSEMBLY = bin/Debug/MCloud.Test.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug/

MCLOUD_TEST_DLL_MDB_SOURCE=bin/Debug/MCloud.Test.dll.mdb
MCLOUD_TEST_DLL_MDB=$(BUILD_DIR)/MCloud.Test.dll.mdb

endif

if ENABLE_DEBUG_X86
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;TRACE"
ASSEMBLY = bin/Debug/MCloud.Test.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug/

MCLOUD_TEST_DLL_MDB_SOURCE=bin/Debug/MCloud.Test.dll.mdb
MCLOUD_TEST_DLL_MDB=$(BUILD_DIR)/MCloud.Test.dll.mdb

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+ "-define:TRACE"
ASSEMBLY = bin/Release/MCloud.Test.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release/

MCLOUD_TEST_DLL_MDB=

endif

if ENABLE_RELEASE_MIXED_PLATFORMS
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+ "-define:TRACE"
ASSEMBLY = bin/Release/MCloud.Test.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release/

MCLOUD_TEST_DLL_MDB=

endif

if ENABLE_RELEASE_X86
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+ "-define:TRACE"
ASSEMBLY = bin/Release/MCloud.Test.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release/

MCLOUD_TEST_DLL_MDB=

endif

AL=al2
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(MCLOUD_TEST_DLL_MDB)  

LINUX_PKGCONFIG = \
	$(MCLOUD_TEST_PC)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

FILES = \
	ListLocationsTest.cs \
	ListSizesTest.cs \
	ListImagesTest.cs \
	ListNodesTest.cs \
	RebootNodeTest.cs \
	DestroyNodeTest.cs \
	UpdateNodeTest.cs \
	CreateNodeTest.cs \
	Properties/AssemblyInfo.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	mcloud.test.pc.in 

REFERENCES =  \
	System.Core \
	System \
	$(MONO_NUNIT_LIBS)

DLL_REFERENCES = 

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

include $(top_srcdir)/Makefile.include

MCLOUD_TEST_PC = $(BUILD_DIR)/mcloud.test.pc

$(eval $(call emit-deploy-wrapper,MCLOUD_TEST_PC,mcloud.test.pc))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
