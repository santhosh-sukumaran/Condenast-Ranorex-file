///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Account_Users
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Account_UsersRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("c5d46546-af41-4678-bfa5-b03389b45d39")]
    public partial class Account_UsersRepository : RepoGenBaseFolder
    {
        static Account_UsersRepository instance = new Account_UsersRepository();
        Account_UsersRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the Account_UsersRepository element repository.
        /// </summary>
        [RepositoryFolder("c5d46546-af41-4678-bfa5-b03389b45d39")]
        public static Account_UsersRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Account_UsersRepository() 
            : base("Account_UsersRepository", "/", null, 0, false, "c5d46546-af41-4678-bfa5-b03389b45d39", ".\\RepositoryImages\\Account_UsersRepositoryc5d46546.rximgres")
        {
            _applicationundertest = new Account_UsersRepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c5d46546-af41-4678-bfa5-b03389b45d39")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("682ad4a6-4570-4fcd-8bb1-d4b6c94a6142")]
        public virtual Account_UsersRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Account_UsersRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("682ad4a6-4570-4fcd-8bb1-d4b6c94a6142")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            Account_UsersRepositoryFolders.IndexTableAccountUsersFolder _indextableaccountusers;
            RepoItemInfo _useremailInfo;
            RepoItemInfo _userpasswordInfo;
            RepoItemInfo _loginbuttonInfo;
            RepoItemInfo _accountusersInfo;
            RepoItemInfo _newaccountuserInfo;
            RepoItemInfo _createaccountuserInfo;
            RepoItemInfo _accountuseraccountidInfo;
            RepoItemInfo _accountuserdefaultdatasourceidInfo;
            RepoItemInfo _accountuseruseridInfo;
            RepoItemInfo _accountidfiltterInfo;
            RepoItemInfo _filtterbuttonInfo;
            RepoItemInfo _useridfiltterInfo;
            RepoItemInfo _tabsInfo;
            RepoItemInfo _clearfiltersInfo;
            RepoItemInfo _logoutInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='obsidian-staging.conde.io']", parentFolder, 30000, null, false, "682ad4a6-4570-4fcd-8bb1-d4b6c94a6142", "")
            {
                _indextableaccountusers = new Account_UsersRepositoryFolders.IndexTableAccountUsersFolder(this);
                _useremailInfo = new RepoItemInfo(this, "UserEmail", ".//input[#'user_email']", 30000, null, "090d4f76-7669-4e79-b009-c6e39ac4e3aa");
                _userpasswordInfo = new RepoItemInfo(this, "UserPassword", ".//input[#'user_password']", 30000, null, "79bb4881-1cfe-4fe2-9fb5-844995917f4e");
                _loginbuttonInfo = new RepoItemInfo(this, "Loginbutton", ".//form[#'new_user']/?/?/input[@name='commit']", 30000, null, "bec42d1e-7567-414e-afa5-8908ea55a6b7");
                _accountusersInfo = new RepoItemInfo(this, "AccountUsers", ".//li[#'account_users']/a[@innertext='Account Users']", 30000, null, "618c7099-1eca-45bb-85a7-8031976c9cd6");
                _newaccountuserInfo = new RepoItemInfo(this, "NewAccountUser", ".//div[#'titlebar_right']//a[@innertext='New Account User']", 30000, null, "68ea5eb4-0fde-4e7c-8e19-7e8fd6e8f625");
                _createaccountuserInfo = new RepoItemInfo(this, "CreateAccountUser", ".//li[#'account_user_submit_action']/input[@name='commit']", 30000, null, "d60190e1-8dae-43d9-b937-00fe2d7c087d");
                _accountuseraccountidInfo = new RepoItemInfo(this, "AccountUserAccountId", ".//select[#'account_user_account_id']", 30000, null, "6147e23f-524a-46ea-9168-206c7ab350aa");
                _accountuserdefaultdatasourceidInfo = new RepoItemInfo(this, "AccountUserDefaultDataSourceId", ".//select[#'account_user_default_data_source_id']", 30000, null, "2d01085f-3b51-4484-97d6-5cdb4dd36022");
                _accountuseruseridInfo = new RepoItemInfo(this, "AccountUserUserId", ".//select[#'account_user_user_id']", 30000, null, "8c71794b-1772-4bc5-9296-8e7fb5e32b9a");
                _accountidfiltterInfo = new RepoItemInfo(this, "AccountIdfiltter", ".//select[#'q_account_id']", 30000, null, "3e43fb6d-527c-40e3-ad84-d1f527929f6d");
                _filtterbuttonInfo = new RepoItemInfo(this, "Filtterbutton", ".//form[#'new_q']/?/?/input[@name='commit']", 30000, null, "0432e773-0736-4c66-b0b4-d5861ef99016");
                _useridfiltterInfo = new RepoItemInfo(this, "UserIdfiltter", ".//select[#'q_user_id']", 30000, null, "2178218d-2584-4f6f-8f1d-5ee367b464f2");
                _tabsInfo = new RepoItemInfo(this, "Tabs", ".//ul[#'tabs']", 30000, null, "08f99866-f95b-4efc-8c2b-56ff62d16010");
                _clearfiltersInfo = new RepoItemInfo(this, "ClearFilters", ".//form[#'new_q']/?/?/a[@innertext='Clear Filters']", 30000, null, "66963b2e-62e1-4db2-9faa-30a65524443f");
                _logoutInfo = new RepoItemInfo(this, "Logout", ".//li[#'logout']/a[@innertext='Logout']", 30000, null, "9cf31ecc-b77a-487c-b666-64253e4eff3e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("682ad4a6-4570-4fcd-8bb1-d4b6c94a6142")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("682ad4a6-4570-4fcd-8bb1-d4b6c94a6142")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The UserEmail item.
            /// </summary>
            [RepositoryItem("090d4f76-7669-4e79-b009-c6e39ac4e3aa")]
            public virtual Ranorex.InputTag UserEmail
            {
                get
                {
                    return _useremailInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The UserEmail item info.
            /// </summary>
            [RepositoryItemInfo("090d4f76-7669-4e79-b009-c6e39ac4e3aa")]
            public virtual RepoItemInfo UserEmailInfo
            {
                get
                {
                    return _useremailInfo;
                }
            }

            /// <summary>
            /// The UserPassword item.
            /// </summary>
            [RepositoryItem("79bb4881-1cfe-4fe2-9fb5-844995917f4e")]
            public virtual Ranorex.InputTag UserPassword
            {
                get
                {
                    return _userpasswordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The UserPassword item info.
            /// </summary>
            [RepositoryItemInfo("79bb4881-1cfe-4fe2-9fb5-844995917f4e")]
            public virtual RepoItemInfo UserPasswordInfo
            {
                get
                {
                    return _userpasswordInfo;
                }
            }

            /// <summary>
            /// The Loginbutton item.
            /// </summary>
            [RepositoryItem("bec42d1e-7567-414e-afa5-8908ea55a6b7")]
            public virtual Ranorex.InputTag Loginbutton
            {
                get
                {
                    return _loginbuttonInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Loginbutton item info.
            /// </summary>
            [RepositoryItemInfo("bec42d1e-7567-414e-afa5-8908ea55a6b7")]
            public virtual RepoItemInfo LoginbuttonInfo
            {
                get
                {
                    return _loginbuttonInfo;
                }
            }

            /// <summary>
            /// The AccountUsers item.
            /// </summary>
            [RepositoryItem("618c7099-1eca-45bb-85a7-8031976c9cd6")]
            public virtual Ranorex.ATag AccountUsers
            {
                get
                {
                    return _accountusersInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The AccountUsers item info.
            /// </summary>
            [RepositoryItemInfo("618c7099-1eca-45bb-85a7-8031976c9cd6")]
            public virtual RepoItemInfo AccountUsersInfo
            {
                get
                {
                    return _accountusersInfo;
                }
            }

            /// <summary>
            /// The NewAccountUser item.
            /// </summary>
            [RepositoryItem("68ea5eb4-0fde-4e7c-8e19-7e8fd6e8f625")]
            public virtual Ranorex.ATag NewAccountUser
            {
                get
                {
                    return _newaccountuserInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The NewAccountUser item info.
            /// </summary>
            [RepositoryItemInfo("68ea5eb4-0fde-4e7c-8e19-7e8fd6e8f625")]
            public virtual RepoItemInfo NewAccountUserInfo
            {
                get
                {
                    return _newaccountuserInfo;
                }
            }

            /// <summary>
            /// The CreateAccountUser item.
            /// </summary>
            [RepositoryItem("d60190e1-8dae-43d9-b937-00fe2d7c087d")]
            public virtual Ranorex.InputTag CreateAccountUser
            {
                get
                {
                    return _createaccountuserInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The CreateAccountUser item info.
            /// </summary>
            [RepositoryItemInfo("d60190e1-8dae-43d9-b937-00fe2d7c087d")]
            public virtual RepoItemInfo CreateAccountUserInfo
            {
                get
                {
                    return _createaccountuserInfo;
                }
            }

            /// <summary>
            /// The AccountUserAccountId item.
            /// </summary>
            [RepositoryItem("6147e23f-524a-46ea-9168-206c7ab350aa")]
            public virtual Ranorex.SelectTag AccountUserAccountId
            {
                get
                {
                    return _accountuseraccountidInfo.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The AccountUserAccountId item info.
            /// </summary>
            [RepositoryItemInfo("6147e23f-524a-46ea-9168-206c7ab350aa")]
            public virtual RepoItemInfo AccountUserAccountIdInfo
            {
                get
                {
                    return _accountuseraccountidInfo;
                }
            }

            /// <summary>
            /// The AccountUserDefaultDataSourceId item.
            /// </summary>
            [RepositoryItem("2d01085f-3b51-4484-97d6-5cdb4dd36022")]
            public virtual Ranorex.SelectTag AccountUserDefaultDataSourceId
            {
                get
                {
                    return _accountuserdefaultdatasourceidInfo.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The AccountUserDefaultDataSourceId item info.
            /// </summary>
            [RepositoryItemInfo("2d01085f-3b51-4484-97d6-5cdb4dd36022")]
            public virtual RepoItemInfo AccountUserDefaultDataSourceIdInfo
            {
                get
                {
                    return _accountuserdefaultdatasourceidInfo;
                }
            }

            /// <summary>
            /// The AccountUserUserId item.
            /// </summary>
            [RepositoryItem("8c71794b-1772-4bc5-9296-8e7fb5e32b9a")]
            public virtual Ranorex.SelectTag AccountUserUserId
            {
                get
                {
                    return _accountuseruseridInfo.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The AccountUserUserId item info.
            /// </summary>
            [RepositoryItemInfo("8c71794b-1772-4bc5-9296-8e7fb5e32b9a")]
            public virtual RepoItemInfo AccountUserUserIdInfo
            {
                get
                {
                    return _accountuseruseridInfo;
                }
            }

            /// <summary>
            /// The AccountIdfiltter item.
            /// </summary>
            [RepositoryItem("3e43fb6d-527c-40e3-ad84-d1f527929f6d")]
            public virtual Ranorex.SelectTag AccountIdfiltter
            {
                get
                {
                    return _accountidfiltterInfo.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The AccountIdfiltter item info.
            /// </summary>
            [RepositoryItemInfo("3e43fb6d-527c-40e3-ad84-d1f527929f6d")]
            public virtual RepoItemInfo AccountIdfiltterInfo
            {
                get
                {
                    return _accountidfiltterInfo;
                }
            }

            /// <summary>
            /// The Filtterbutton item.
            /// </summary>
            [RepositoryItem("0432e773-0736-4c66-b0b4-d5861ef99016")]
            public virtual Ranorex.InputTag Filtterbutton
            {
                get
                {
                    return _filtterbuttonInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Filtterbutton item info.
            /// </summary>
            [RepositoryItemInfo("0432e773-0736-4c66-b0b4-d5861ef99016")]
            public virtual RepoItemInfo FiltterbuttonInfo
            {
                get
                {
                    return _filtterbuttonInfo;
                }
            }

            /// <summary>
            /// The UserIdfiltter item.
            /// </summary>
            [RepositoryItem("2178218d-2584-4f6f-8f1d-5ee367b464f2")]
            public virtual Ranorex.SelectTag UserIdfiltter
            {
                get
                {
                    return _useridfiltterInfo.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The UserIdfiltter item info.
            /// </summary>
            [RepositoryItemInfo("2178218d-2584-4f6f-8f1d-5ee367b464f2")]
            public virtual RepoItemInfo UserIdfiltterInfo
            {
                get
                {
                    return _useridfiltterInfo;
                }
            }

            /// <summary>
            /// The Tabs item.
            /// </summary>
            [RepositoryItem("08f99866-f95b-4efc-8c2b-56ff62d16010")]
            public virtual Ranorex.UlTag Tabs
            {
                get
                {
                    return _tabsInfo.CreateAdapter<Ranorex.UlTag>(true);
                }
            }

            /// <summary>
            /// The Tabs item info.
            /// </summary>
            [RepositoryItemInfo("08f99866-f95b-4efc-8c2b-56ff62d16010")]
            public virtual RepoItemInfo TabsInfo
            {
                get
                {
                    return _tabsInfo;
                }
            }

            /// <summary>
            /// The ClearFilters item.
            /// </summary>
            [RepositoryItem("66963b2e-62e1-4db2-9faa-30a65524443f")]
            public virtual Ranorex.ATag ClearFilters
            {
                get
                {
                    return _clearfiltersInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ClearFilters item info.
            /// </summary>
            [RepositoryItemInfo("66963b2e-62e1-4db2-9faa-30a65524443f")]
            public virtual RepoItemInfo ClearFiltersInfo
            {
                get
                {
                    return _clearfiltersInfo;
                }
            }

            /// <summary>
            /// The Logout item.
            /// </summary>
            [RepositoryItem("9cf31ecc-b77a-487c-b666-64253e4eff3e")]
            public virtual Ranorex.ATag Logout
            {
                get
                {
                    return _logoutInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Logout item info.
            /// </summary>
            [RepositoryItemInfo("9cf31ecc-b77a-487c-b666-64253e4eff3e")]
            public virtual RepoItemInfo LogoutInfo
            {
                get
                {
                    return _logoutInfo;
                }
            }

            /// <summary>
            /// The IndexTableAccountUsers folder.
            /// </summary>
            [RepositoryFolder("39bd02b9-73ef-48ef-aec4-3a7930d7027e")]
            public virtual Account_UsersRepositoryFolders.IndexTableAccountUsersFolder IndexTableAccountUsers
            {
                get { return _indextableaccountusers; }
            }
        }

        /// <summary>
        /// The IndexTableAccountUsersFolder folder.
        /// </summary>
        [RepositoryFolder("39bd02b9-73ef-48ef-aec4-3a7930d7027e")]
        public partial class IndexTableAccountUsersFolder : RepoGenBaseFolder
        {
            RepoItemInfo _deleteInfo;
            RepoItemInfo _editInfo;
            RepoItemInfo _viewInfo;

            /// <summary>
            /// Creates a new IndexTableAccountUsers  folder.
            /// </summary>
            public IndexTableAccountUsersFolder(RepoGenBaseFolder parentFolder) :
                    base("IndexTableAccountUsers", ".//table[#'index_table_account_users']", parentFolder, 30000, null, false, "39bd02b9-73ef-48ef-aec4-3a7930d7027e", "")
            {
                _deleteInfo = new RepoItemInfo(this, "Delete", "tbody/tr[1]/td[8]/?/?/a[@innertext='Delete']", 30000, null, "c1fcaf1e-3018-473e-a615-d832fd69f63b");
                _editInfo = new RepoItemInfo(this, "Edit", "tbody/tr[1]/td[8]/?/?/a[@innertext='Edit']", 30000, null, "8b81d97c-b9f6-4a79-b05d-f637d28846b6");
                _viewInfo = new RepoItemInfo(this, "View", "tbody/tr[1]/td[8]/?/?/a[@innertext='View']", 30000, null, "6b34c7cb-3fc7-41f1-bcfa-2b8b366aace6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("39bd02b9-73ef-48ef-aec4-3a7930d7027e")]
            public virtual Ranorex.Table Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("39bd02b9-73ef-48ef-aec4-3a7930d7027e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Delete item.
            /// </summary>
            [RepositoryItem("c1fcaf1e-3018-473e-a615-d832fd69f63b")]
            public virtual Ranorex.ATag Delete
            {
                get
                {
                    return _deleteInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Delete item info.
            /// </summary>
            [RepositoryItemInfo("c1fcaf1e-3018-473e-a615-d832fd69f63b")]
            public virtual RepoItemInfo DeleteInfo
            {
                get
                {
                    return _deleteInfo;
                }
            }

            /// <summary>
            /// The Edit item.
            /// </summary>
            [RepositoryItem("8b81d97c-b9f6-4a79-b05d-f637d28846b6")]
            public virtual Ranorex.ATag Edit
            {
                get
                {
                    return _editInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Edit item info.
            /// </summary>
            [RepositoryItemInfo("8b81d97c-b9f6-4a79-b05d-f637d28846b6")]
            public virtual RepoItemInfo EditInfo
            {
                get
                {
                    return _editInfo;
                }
            }

            /// <summary>
            /// The View item.
            /// </summary>
            [RepositoryItem("6b34c7cb-3fc7-41f1-bcfa-2b8b366aace6")]
            public virtual Ranorex.ATag View
            {
                get
                {
                    return _viewInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The View item info.
            /// </summary>
            [RepositoryItemInfo("6b34c7cb-3fc7-41f1-bcfa-2b8b366aace6")]
            public virtual RepoItemInfo ViewInfo
            {
                get
                {
                    return _viewInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
