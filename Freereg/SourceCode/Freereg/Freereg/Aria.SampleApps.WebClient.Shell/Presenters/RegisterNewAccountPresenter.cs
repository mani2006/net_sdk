﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterNewAccountPresenter.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Register New Account Presenter
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Data;
using Aria.SampleApps.Business.Services;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.WebClient.Shell.Views;
using Microsoft.Practices.CompositeWeb;

namespace Aria.SampleApps.WebClient.Shell.Presenters
{
    public class RegisterNewAccountPresenter : Presenter<IRegisterNewAccountView>
    {
        public IGeneralServices GeneralServices { get; set; }
        

        /// <summary>
        /// Loads the labels list.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void LoadLabelsList()
        {
            View.LabelsList = GeneralServices.GetLabelsDictionary();
        }

        /// <summary>
        /// Loads the drop down lists.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void LoadDropDownLists()
        {
            View.CountryList = GeneralServices.GetCountryList();
        }

        /// <summary>
        /// Users the id exsist.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public bool UserIdExsist(string userId)
        {
            return GeneralServices.UserIdExsist(userId);
        }
    }
}
