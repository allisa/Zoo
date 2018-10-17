using System;
using Xunit;
using Zoo.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Proves that a dervied class inherits from the base class
        /// Also proves overriding virtual method
        /// </summary>
        [Fact]
        public void CanProveRobinIsDerivedFromAnimal()
        {
            Robin rob = new Robin();
            Assert.Equal("Food", rob.Eat());
        }

        /// <summary>
        /// Tests for property overriding
        /// </summary>
        [Fact]
        public void CanOverrideMethod()
        {
            Rattlesnake rattles = new Rattlesnake();
            Dog fluffy = new Dog();

            Assert.Equal(0, rattles.HasLegs);
            Assert.Equal(4, fluffy.HasLegs);
        }

        /// <summary>
        /// Testing interface implementation
        /// </summary>
        [Fact]
        public static void CanImplementInterface()
        {
            Dog fluffy = new Dog();
            Assert.Equal("People love me to cuddle with them", fluffy.LiveInsideHomes());
        }

        /// <summary>
        /// Testing overriding abstract properties
        /// </summary>
        [Fact]
        public static void CanOverrideAbstractProperty()
        {
            Fish fishy = new Fish();

            Assert.True(fishy.IsWarmBlooded);
        }
    }
}
