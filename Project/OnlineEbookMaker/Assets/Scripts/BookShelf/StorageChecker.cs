using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StorageChecker
{
    const int LIMIT = 12;
    public static bool IsStorgaeLimit(BookIdContainer idContainer)
    {
        return idContainer.Count >= LIMIT;
    }
}
