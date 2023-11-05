﻿namespace Xod.Attributes;

/// <summary>
/// For runtime properties that are not persisted in the database files
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class NotMappedAttribute : Attribute
{
}