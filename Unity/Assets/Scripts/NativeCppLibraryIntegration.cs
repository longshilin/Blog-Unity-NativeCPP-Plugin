using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class NativeCppLibraryIntegration : MonoBehaviour
{
#if UNITY_IPHONE && !UNITY_EDITOR
        const string KcpDLL = "__Internal";
#else
    const string Tree234DLL = "tree234";
#endif

    // Import and expose native c++ functions
    [DllImport(Tree234DLL, EntryPoint = "displayNumber")]
    public static extern int displayNumber();

    [DllImport(Tree234DLL, EntryPoint = "getRandom")]
    public static extern int getRandom();

    [DllImport(Tree234DLL, EntryPoint = "displaySum")]
    public static extern int displaySum();

// Start is called before the first frame update
    void Start()
    {
        // Display output of functions
        print(displayNumber());
        print(getRandom());
        print(displaySum());
    }
}