﻿
        class TESTIDSchemaFilter : Swashbuckle.AspNetCore.SwaggerGen.ISchemaFilter
        {
            public void Apply(Microsoft.OpenApi.Models.OpenApiSchema schema, Swashbuckle.AspNetCore.SwaggerGen.SchemaFilterContext context)
            {
                var idSchema = new Microsoft.OpenApi.Models.OpenApiSchema {Type = "integer", Format = "int64"};
                schema.Type = idSchema.Type;
                schema.Format = idSchema.Format;
                schema.Example = idSchema.Example;
                schema.Default = idSchema.Default;
                schema.Properties = idSchema.Properties;
            }
        }