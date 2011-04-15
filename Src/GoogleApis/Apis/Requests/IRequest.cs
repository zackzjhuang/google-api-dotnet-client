/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.IO;
using System.Collections.Generic;
using Google.Apis.Authentication;

namespace Google.Apis.Requests {
    /// <summary>
    /// Implementors will be able to make a request to a service.
    /// </summary>
	public interface IRequest {
		IRequest On(string rpcName);
		IRequest Returning(ReturnType returnType);
		IRequest WithParameters(IDictionary<string, string> parameters);
		IRequest WithParameters(string parameters);
		IRequest WithBody(IDictionary<string, string> parameters);
		IRequest WithBody(string body);
		IRequest WithAuthentication(IAuthenticator authenticator); 
        IRequest WithDeveloperKey(string key);
		Stream ExecuteRequest();
	}
}