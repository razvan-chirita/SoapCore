using System;
using System.Collections.Generic;
using System.Text;

namespace SoapCore.Attributes
{
	[AttributeUsage(AttributeTargets.Method)]
	public class OperationContractExtensionAttribute : Attribute
	{
		public string ResponseEnvelopeName { get; set; } = null;
		public bool SkipResponseEnvelope { get; set; } = false;
	}
}
