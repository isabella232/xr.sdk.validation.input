﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using UnityEngine.SceneManagement;

namespace Tests
{
    public class InputManual
    {
        [UnityTest]
        [Timeout(3600000)] // An hour
        [Description("This test verifies haptic response with a physical controller.")]
        public IEnumerator InputHaptics()
        {
            yield return TestFunctions.RunFacilitatorSceneTest("InputHaptics");
        }

        [UnityTest]
        [Timeout(3600000)] // An hour
        [Description("This test verifies Recenter functionality.")]
        public IEnumerator InputRecenter()
        {
            yield return TestFunctions.RunFacilitatorSceneTest("InputRecenter");
        }

        [UnityTest]
        [Timeout(3600000)] // An hour
        [Description("This test verifies Feature/Usage controls specifics.")]
        public IEnumerator InputFeatureUsageControls()
        {
            yield return TestFunctions.RunFacilitatorSceneTest("InputFeatureUsageControls");
        }

        [UnityTest]
        [Timeout(3600000)] // An hour
        [Description("This test verifies Feature/Usage tracking specifics.")]
        public IEnumerator InputFeatureUsageTracking()
        {
            yield return TestFunctions.RunFacilitatorSceneTest("InputFeatureUsageTracking");
        }

        [UnityTest]
        [Timeout(3600000)] // An hour
        [Description("This test verifies Device names, manufacturer, and serial number information.")]
        public IEnumerator NameManfSerial()
        {
            yield return TestFunctions.RunFacilitatorSceneTest("NameManfSerial");
        }

        [UnityTest]
        [Timeout(3600000)] // An hour
        [Description("This test verifies information that requires viewing all features at once.")]
        public IEnumerator InputArray()
        {
            yield return TestFunctions.RunFacilitatorSceneTest("InputArray");
        }
        
        [UnityTest]
        [Timeout(3600000)] // An hour
        [Description("This test verifies TrackingOriginType and Boundary functions.")]
        public IEnumerator InputExperience()
        {
            yield return TestFunctions.RunFacilitatorSceneTest("InputExperience");
        }
    }
}
