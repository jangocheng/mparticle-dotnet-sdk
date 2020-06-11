


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using mParticle.Sdk.Api;
using mParticle.Sdk.Model;
using mParticle.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace mParticle.Sdk.Test
{
    /// <summary>
    ///  Class for testing CommerceEventData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CommerceEventDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CommerceEventData
        //private CommerceEventData instance;

        public CommerceEventDataTests()
        {
            // TODO uncomment below to create an instance of CommerceEventData
            //instance = new CommerceEventData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CommerceEventData
        /// </summary>
        [Fact]
        public void CommerceEventDataInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CommerceEventData
            //Assert.IsInstanceOfType<CommerceEventData> (instance, "variable 'instance' is a CommerceEventData");
        }


        /// <summary>
        /// Test the property 'TimestampUnixtimeMs'
        /// </summary>
        [Fact]
        public void TimestampUnixtimeMsTest()
        {
            // TODO unit test for the property 'TimestampUnixtimeMs'
        }
        /// <summary>
        /// Test the property 'EventId'
        /// </summary>
        [Fact]
        public void EventIdTest()
        {
            // TODO unit test for the property 'EventId'
        }
        /// <summary>
        /// Test the property 'SourceMessageId'
        /// </summary>
        [Fact]
        public void SourceMessageIdTest()
        {
            // TODO unit test for the property 'SourceMessageId'
        }
        /// <summary>
        /// Test the property 'SessionId'
        /// </summary>
        [Fact]
        public void SessionIdTest()
        {
            // TODO unit test for the property 'SessionId'
        }
        /// <summary>
        /// Test the property 'SessionUuid'
        /// </summary>
        [Fact]
        public void SessionUuidTest()
        {
            // TODO unit test for the property 'SessionUuid'
        }
        /// <summary>
        /// Test the property 'SessionStartUnixtimeMs'
        /// </summary>
        [Fact]
        public void SessionStartUnixtimeMsTest()
        {
            // TODO unit test for the property 'SessionStartUnixtimeMs'
        }
        /// <summary>
        /// Test the property 'EventStartUnixtimeMs'
        /// </summary>
        [Fact]
        public void EventStartUnixtimeMsTest()
        {
            // TODO unit test for the property 'EventStartUnixtimeMs'
        }
        /// <summary>
        /// Test the property 'CustomAttributes'
        /// </summary>
        [Fact]
        public void CustomAttributesTest()
        {
            // TODO unit test for the property 'CustomAttributes'
        }
        /// <summary>
        /// Test the property 'Location'
        /// </summary>
        [Fact]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }
        /// <summary>
        /// Test the property 'DeviceCurrentState'
        /// </summary>
        [Fact]
        public void DeviceCurrentStateTest()
        {
            // TODO unit test for the property 'DeviceCurrentState'
        }
        /// <summary>
        /// Test the property 'IsGoalDefined'
        /// </summary>
        [Fact]
        public void IsGoalDefinedTest()
        {
            // TODO unit test for the property 'IsGoalDefined'
        }
        /// <summary>
        /// Test the property 'LifetimeValueChange'
        /// </summary>
        [Fact]
        public void LifetimeValueChangeTest()
        {
            // TODO unit test for the property 'LifetimeValueChange'
        }
        /// <summary>
        /// Test the property 'LifetimeValueAttributeName'
        /// </summary>
        [Fact]
        public void LifetimeValueAttributeNameTest()
        {
            // TODO unit test for the property 'LifetimeValueAttributeName'
        }
        /// <summary>
        /// Test the property 'DataConnectionType'
        /// </summary>
        [Fact]
        public void DataConnectionTypeTest()
        {
            // TODO unit test for the property 'DataConnectionType'
        }
        /// <summary>
        /// Test the property 'EventNum'
        /// </summary>
        [Fact]
        public void EventNumTest()
        {
            // TODO unit test for the property 'EventNum'
        }
        /// <summary>
        /// Test the property 'ViewController'
        /// </summary>
        [Fact]
        public void ViewControllerTest()
        {
            // TODO unit test for the property 'ViewController'
        }
        /// <summary>
        /// Test the property 'IsMainThread'
        /// </summary>
        [Fact]
        public void IsMainThreadTest()
        {
            // TODO unit test for the property 'IsMainThread'
        }
        /// <summary>
        /// Test the property 'CanonicalName'
        /// </summary>
        [Fact]
        public void CanonicalNameTest()
        {
            // TODO unit test for the property 'CanonicalName'
        }
        /// <summary>
        /// Test the property 'EventSystemNotificationInfo'
        /// </summary>
        [Fact]
        public void EventSystemNotificationInfoTest()
        {
            // TODO unit test for the property 'EventSystemNotificationInfo'
        }
        /// <summary>
        /// Test the property 'ProductAction'
        /// </summary>
        [Fact]
        public void ProductActionTest()
        {
            // TODO unit test for the property 'ProductAction'
        }
        /// <summary>
        /// Test the property 'PromotionAction'
        /// </summary>
        [Fact]
        public void PromotionActionTest()
        {
            // TODO unit test for the property 'PromotionAction'
        }
        /// <summary>
        /// Test the property 'ProductImpressions'
        /// </summary>
        [Fact]
        public void ProductImpressionsTest()
        {
            // TODO unit test for the property 'ProductImpressions'
        }
        /// <summary>
        /// Test the property 'ShoppingCart'
        /// </summary>
        [Fact]
        public void ShoppingCartTest()
        {
            // TODO unit test for the property 'ShoppingCart'
        }
        /// <summary>
        /// Test the property 'CurrencyCode'
        /// </summary>
        [Fact]
        public void CurrencyCodeTest()
        {
            // TODO unit test for the property 'CurrencyCode'
        }
        /// <summary>
        /// Test the property 'ScreenName'
        /// </summary>
        [Fact]
        public void ScreenNameTest()
        {
            // TODO unit test for the property 'ScreenName'
        }
        /// <summary>
        /// Test the property 'IsNonInteractive'
        /// </summary>
        [Fact]
        public void IsNonInteractiveTest()
        {
            // TODO unit test for the property 'IsNonInteractive'
        }
        /// <summary>
        /// Test the property 'EventName'
        /// </summary>
        [Fact]
        public void EventNameTest()
        {
            // TODO unit test for the property 'EventName'
        }
        /// <summary>
        /// Test the property 'CustomEventType'
        /// </summary>
        [Fact]
        public void CustomEventTypeTest()
        {
            // TODO unit test for the property 'CustomEventType'
        }
        /// <summary>
        /// Test the property 'CustomFlags'
        /// </summary>
        [Fact]
        public void CustomFlagsTest()
        {
            // TODO unit test for the property 'CustomFlags'
        }

    }

}