﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------
namespace NewPlatform.Flexberry.ORM.ODataService.Tests
{
    using System;
    using System.Xml;


    // *** Start programmer edit section *** (Using statements)
    using System.Collections.Generic;
    using ICSSoft.STORMNET;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// CarBS.
    /// </summary>
    // *** Start programmer edit section *** (CarBS CustomAttributes)

    // *** End programmer edit section *** (CarBS CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class CarBS : ICSSoft.STORMNET.Business.BusinessServer
    {
        
        // *** Start programmer edit section *** (CarBS CustomMembers)

        // *** End programmer edit section *** (CarBS CustomMembers)

        
        // *** Start programmer edit section *** (OnUpdateCar CustomAttributes)

        // *** End programmer edit section *** (OnUpdateCar CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateCar(NewPlatform.Flexberry.ORM.ODataService.Tests.Car UpdatedObject)
        {
            // *** Start programmer edit section *** (OnUpdateCar)
            var dObjs = new List<DataObject>();

            if (UpdatedObject.GetStatus() == ICSSoft.STORMNET.ObjectStatus.Created)
            {
                UpdatedObject.Driver.CarCount++;

                UpdatedObject.Number =
                    string.Format("{0}/{1}",
                        "TECT",
                        UpdatedObject.Driver.CarCount);

                dObjs.Add(UpdatedObject.Driver);
            }

            return dObjs.ToArray();
            // *** End programmer edit section *** (OnUpdateCar)
        }
    }
}
