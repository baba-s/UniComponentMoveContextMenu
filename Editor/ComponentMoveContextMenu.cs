using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace Kogane.Internal
{
	internal static class ComponentMoveContextMenu
	{
		[MenuItem( "CONTEXT/Component/Move Top" )]
		private static void MoveTop( MenuCommand command )
		{
			var component = ( Component ) command.context;
			while ( ComponentUtility.MoveComponentUp( component ) )
			{
			}
		}
	}
}