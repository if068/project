﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLInfoCollectionService.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SQLInfoCollectorService.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [databases].[database_id]
        ///	  ,[databases].[name]
        ///	  ,[master_files].[size]
        ///  FROM [master].[sys].[databases] AS databases
        ///  JOIN (
        ///		SELECT [database_id], sum([size]) AS [size] FROM [master].[sys].[master_files] 
        ///			GROUP BY [database_id]
        ///		) AS master_files 
        ///  ON [databases].database_id = [master_files].database_id.
        /// </summary>
        internal static string databases2008 {
            get {
                return ResourceManager.GetString("databases2008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @DBName SYSNAME
        ///DECLARE @DBId INT
        ///
        ///DECLARE @DBPermissions TABLE(
        ///	 database_id INT not null
        ///	,permission_name NVARCHAR(128) not null
        ///	,state_desc NVARCHAR(128) not null
        ///	,grantee_principal_id INT not null);
        ///
        ///DECLARE DBPermissionsCursor CURSOR
        ///	FORWARD_ONLY FAST_FORWARD READ_ONLY LOCAL
        ///	FOR
        ///		SELECT [databases].[name], [databases].[database_id]
        ///		FROM [master].[sys].[databases] 
        ///	OPEN DBPermissionsCursor
        ///	FETCH NEXT FROM DBPermissionsCursor INTO @DBName, @DBId
        ///	WHILE @@FETCH_STATUS =  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string dbPermissions2008 {
            get {
                return ResourceManager.GetString("dbPermissions2008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @DBName SYSNAME
        ///DECLARE @DBId INT
        ///
        ///DECLARE @DBRoles TABLE(
        ///	 database_id INT NOT NULL
        ///	,principal_id INT NOT NULL
        ///	,name NVARCHAR(128) NOT NULL
        ///	,type_desc NVARCHAR(128) NOT NULL
        ///	,member_principal_id INT NOT NULL);
        ///
        ///DECLARE DBRolesCursor CURSOR
        ///	FORWARD_ONLY FAST_FORWARD READ_ONLY LOCAL
        ///	FOR
        ///		SELECT [databases].[name], [databases].[database_id]
        ///		FROM [master].[sys].[databases] 
        ///	OPEN DBRolesCursor
        ///	FETCH NEXT FROM DBRolesCursor INTO @DBName, @DBId
        ///	WHILE @@FETCH_STATUS = 0
        ///		BEG [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string dbRoles2008 {
            get {
                return ResourceManager.GetString("dbRoles2008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @DBName SYSNAME
        ///DECLARE @DBId INT
        ///
        ///DECLARE @DBUsers TABLE(
        ///	 database_id INT not null
        ///	,principal_id INT not null
        ///	,name NVARCHAR(128) not null
        ///	,type_desc NVARCHAR(128) not null
        ///	);
        ///
        ///DECLARE DBUsersCursor CURSOR
        ///	FORWARD_ONLY FAST_FORWARD READ_ONLY LOCAL
        ///	FOR
        ///		SELECT [databases].[name], [databases].[database_id]
        ///		FROM [master].[sys].[databases] 
        ///	OPEN DBUsersCursor
        ///	FETCH NEXT FROM DBUsersCursor INTO @DBName, @DBId
        ///	WHILE @@FETCH_STATUS = 0
        ///		BEGIN
        ///			DECLARE @Sql NVARCHAR(MAX) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string dbUsers2008 {
            get {
                return ResourceManager.GetString("dbUsers2008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 	DECLARE @InstanceDetails TABLE(
        ///		id int NOT NULL,
        ///		Name nvarchar(128),
        ///		Iternal_Value int,
        ///		Character_Value nvarchar(128));
        ///		
        ///	INSERT @InstanceDetails EXEC xp_msver;
        ///	SELECT Name,Character_Value FROM @InstanceDetails 
        ///	WHERE Name IN (&apos;Platform&apos;, &apos;WindowsVersion&apos;, &apos;ProductVersion&apos;).
        /// </summary>
        internal static string instanceDetails2008 {
            get {
                return ResourceManager.GetString("instanceDetails2008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  SELECT [principal_id]
        ///	     ,[name]
        ///	     ,[type_desc]
        ///	     ,[is_disabled]
        ///  FROM [master].[sys].[server_principals] 
        ///		WHERE [type] IN (&apos;S&apos;,&apos;U&apos;).
        /// </summary>
        internal static string instanceLogins2008 {
            get {
                return ResourceManager.GetString("instanceLogins2008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [permission_name]
        ///      ,[state_desc]
        ///      ,[grantee_principal_id]
        ///  FROM [master].[sys].[server_permissions].
        /// </summary>
        internal static string instancePermissions2008 {
            get {
                return ResourceManager.GetString("instancePermissions2008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  [server_roles].[principal_id], [server_roles].[name], 
        ///		[server_roles].[type_desc], [server_role_members].[member_principal_id]
        ///FROM [master].[sys].[server_role_members] AS [server_role_members]
        ///JOIN (SELECT [name] ,[principal_id] ,[type_desc] 
        ///			FROM [master].[sys].[server_principals] 
        ///			WHERE [type] = &apos;R&apos;) AS [server_roles]
        ///ON [server_role_members].[role_principal_id] = [server_roles].[principal_id];.
        /// </summary>
        internal static string instanceRoles2008 {
            get {
                return ResourceManager.GetString("instanceRoles2008", resourceCulture);
            }
        }
    }
}
