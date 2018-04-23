using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace HowToUseCriteriaPropertyEditors.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Person samplePerson1 = Session.FindObject<Person>(CriteriaOperator.Parse("FullName == 'Mary Tellitson'"));
            if (samplePerson1 == null) {
                samplePerson1 = new Person(Session);
                samplePerson1.FirstName = "Mary";
                samplePerson1.LastName = "Tellitson";
                samplePerson1.Save();
            }
            Person samplePerson2 = Session.FindObject<Person>(CriteriaOperator.Parse("FullName == 'John Nilsen'"));
            if (samplePerson2 == null) {
                samplePerson2 = new Person(Session);
                samplePerson2.FirstName = "John";
                samplePerson2.LastName = "Nilsen";
                samplePerson2.Save();
            }
            Product sampleProduct1 = Session.FindObject<Product>(CriteriaOperator.Parse("Name == 'Geitost'"));
            if (sampleProduct1 == null) {
                sampleProduct1 = new Product(Session);
                sampleProduct1.Name = "Geitost";
                sampleProduct1.Price = 2;
                sampleProduct1.Quantity = 25;
                sampleProduct1.Manager = samplePerson1;
                sampleProduct1.Save();
            }
            Product sampleProduct2 = Session.FindObject<Product>(CriteriaOperator.Parse("Name == 'Maxilaku'"));
            if (sampleProduct2 == null) {
                sampleProduct2 = new Product(Session);
                sampleProduct2.Name = "Maxilaku";
                sampleProduct2.Price = 16;
                sampleProduct2.Quantity = 40;
                sampleProduct2.Manager = samplePerson1;
                sampleProduct2.Save();
            }
            Product sampleProduct3 = Session.FindObject<Product>(CriteriaOperator.Parse("Name == 'Queso Cabrales'"));
            if (sampleProduct3 == null) {
                sampleProduct3 = new Product(Session);
                sampleProduct3.Name = "Queso Cabrales";
                sampleProduct3.Price = 14;
                sampleProduct3.Quantity = 12;
                sampleProduct3.Manager = samplePerson2;
                sampleProduct3.Save();
            }
            Product sampleProduct4 = Session.FindObject<Product>(CriteriaOperator.Parse("Name == 'Ravioli Angelo'"));
            if (sampleProduct4 == null) {
                sampleProduct4 = new Product(Session);
                sampleProduct4.Name = "Ravioli Angelo";
                sampleProduct4.Price = 15.6;
                sampleProduct4.Quantity = 15;
                sampleProduct4.Manager = samplePerson2;
                sampleProduct4.Save();
            }
            Product sampleProduct5 = Session.FindObject<Product>(CriteriaOperator.Parse("Name == 'Tofu'"));
            if (sampleProduct5 == null) {
                sampleProduct5 = new Product(Session);
                sampleProduct5.Name = "Tofu";
                sampleProduct5.Price = 18.6;
                sampleProduct5.Quantity = 9;
                sampleProduct5.Manager = samplePerson2;
                sampleProduct5.Save();
            }
            FilteringCriterion sampleCriterion = Session.FindObject<FilteringCriterion>(CriteriaOperator.Parse("Description == 'Low on stock'"));
            if (sampleCriterion == null) {
                sampleCriterion = new FilteringCriterion(Session);
                sampleCriterion.Description = "Low on stock";
                sampleCriterion.Criterion = "[Quantity] < 10";
                sampleCriterion.Save();
            }
            FilteringCriterion sampleCriterion2 = Session.FindObject<FilteringCriterion>(CriteriaOperator.Parse("Description == 'Cheap'"));
            if (sampleCriterion2 == null) {
                sampleCriterion2 = new FilteringCriterion(Session);
                sampleCriterion2.Description = "Cheap";
                sampleCriterion2.Criterion = "[Price] < 5.0";
                sampleCriterion2.Save();
            }
            FilteringCriterion sampleCriterion3 = Session.FindObject<FilteringCriterion>(CriteriaOperator.Parse("Description == 'Expensive'"));
            if (sampleCriterion3 == null) {
                sampleCriterion3 = new FilteringCriterion(Session);
                sampleCriterion3.Description = "Expensive";
                sampleCriterion3.Criterion = "[Price] > 15.0";
                sampleCriterion3.Save();
            }
            FilteringCriterion sampleCriterion4 = Session.FindObject<FilteringCriterion>(CriteriaOperator.Parse("Description == 'Overstocked'"));
            if (sampleCriterion4 == null) {
                sampleCriterion4 = new FilteringCriterion(Session);
                sampleCriterion4.Description = "Overstocked";
                sampleCriterion4.Criterion = "[Quantity] > 30";
                sampleCriterion4.Save();
            }
            FilteringCriterion sampleCriterion5 = Session.FindObject<FilteringCriterion>(CriteriaOperator.Parse("Description == 'Manager is Mary Tellitson'"));
            if(sampleCriterion5 == null) {
                sampleCriterion5 = new FilteringCriterion(Session);
                sampleCriterion5.Description = "Manager is Mary Tellitson";
                sampleCriterion5.Criterion = 
                    "[Manager] = '@ObjectType:" + samplePerson1.GetType().ToString() + 
                    "@ObjectID:" + samplePerson1.Oid + "'";
                sampleCriterion5.Save();
            }
            FilteringCriterion sampleCriterion6 = Session.FindObject<FilteringCriterion>(CriteriaOperator.Parse("Description == 'Manager is John Nilsen'"));
            if(sampleCriterion6 == null) {
                sampleCriterion6 = new FilteringCriterion(Session);
                sampleCriterion6.Description = "Manager is John Nilsen";
                sampleCriterion6.Criterion =
                    "[Manager] = '@ObjectType:" + samplePerson2.GetType().ToString() +
                    "@ObjectID:" + samplePerson2.Oid + "'";
                sampleCriterion6.Save();
            }
        }
    }
}
