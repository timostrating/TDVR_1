using UnityEngine;
using UnityEditor;
using System.Collections;

/**
 * JS compiled in Editor pass doesn't know about CS compiled in Editor pass.
 */
public class QuickEdit_About : Editor
{
	[MenuItem("Tools/QuickEdit/About", false, 0)]
	public static void MenuAbout ()
	{
		pc_AboutWindow.Init("Assets/ProCore/QuickEdit/About/pc_AboutEntry_QuickEdit.txt", true);
	}
}
