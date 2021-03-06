﻿/*
 * Copyright 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Threading.Tasks;
using IdentityServer3.WsFederation.Models;

namespace IdentityServer3.WsFederation.Services
{
    /// <summary>
    ///  Models the logic when validating post logout redirect URIs.
    /// </summary>
    public interface IRedirectUriValidator
    {
        /// <summary>
        /// Determines whether a post logout URI is valid.
        /// </summary>
        /// <param name="requestedUri">The requested URI.</param>
        /// <param name="relyingParty"></param>
        /// <returns>
        ///   <c>true</c> is the URI is valid; <c>false</c> otherwise.
        /// </returns>
        Task<bool> IsPostLogoutRedirectUriValidAsync(string requestedUri, RelyingParty relyingParty);
    }
}