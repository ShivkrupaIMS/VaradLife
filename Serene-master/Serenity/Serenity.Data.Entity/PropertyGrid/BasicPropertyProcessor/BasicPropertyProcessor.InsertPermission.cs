﻿using Serenity.ComponentModel;
using Serenity.Data;

namespace Serenity.PropertyGrid
{
    public partial class BasicPropertyProcessor : PropertyProcessor
    {
        private void SetInsertPermission(IPropertySource source, PropertyItem item)
        {
            if (source.Property != null)
            {
                var attr = source.Property.GetAttribute<InsertPermissionAttribute>(false);
                if (attr != null)
                {
                    if (attr.Permission != "*")
                        item.InsertPermission = attr.Permission ?? "?";

                    return;
                }
            }

            if (!ReferenceEquals(null, source.BasedOnField))
            {
                if (source.BasedOnField.InsertPermission != null &&
                    source.BasedOnField.InsertPermission != "*")
                    item.InsertPermission = source.BasedOnField.InsertPermission;
            }
        }
    }
}