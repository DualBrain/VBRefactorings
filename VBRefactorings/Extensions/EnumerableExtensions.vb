﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.
'

Imports System.Runtime.CompilerServices

Namespace Utilities
    Public Module EnumerableExtensions

        <Extension>
        Public Function Contains(Of T)(ByVal sequence As IEnumerable(Of T), predicate As Func(Of T, Boolean)) As Boolean
            Return sequence.Any(predicate)
        End Function

    End Module
End Namespace
