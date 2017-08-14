/**
* Copyright 2017 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using Newtonsoft.Json;
using System;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.Model
{
    /// <summary>
    /// Counterexample.
    /// </summary>
    public class Counterexample
    {
        /// <summary>
        /// The text of the counterexample.
        /// </summary>
        /// <value>The text of the counterexample.</value>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>
        /// The timestamp for creation of the counterexample.
        /// </summary>
        /// <value>The timestamp for creation of the counterexample.</value>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime Created { get; private set; }
        /// <summary>
        /// The timestamp for the last update to the counterexample.
        /// </summary>
        /// <value>The timestamp for the last update to the counterexample.</value>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime Updated { get; private set; }
    }

}