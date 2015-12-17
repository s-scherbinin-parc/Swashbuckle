using System;
using Newtonsoft.Json.Serialization;

namespace Swashbuckle.Swagger
{
	public interface IModelFilter
	{
		void Apply(Schema model, ModelFilterContext context);
	}

	public class ModelFilterContext
	{
		public ModelFilterContext(
			Type systemType,
			JsonObjectContract jsonObjectContract,
			SchemaRegistry schemaRegistry)
		{
			SystemType = systemType;
			JsonObjectContract = jsonObjectContract;
			SchemaRegistry = schemaRegistry;
		}

		public ModelFilterContext(
			Type systemType,
			JsonDynamicContract jsonDynamicContract,
			SchemaRegistry schemaRegistry)
		{
			SystemType = systemType;
			JsonDynamicContract = jsonDynamicContract;
			SchemaRegistry = schemaRegistry;
		}

		public Type SystemType { get; private set; }

		public JsonObjectContract JsonObjectContract { get; private set; }
		public JsonDynamicContract JsonDynamicContract { get; private set; }

		public SchemaRegistry SchemaRegistry { get; private set; }
	}
}
