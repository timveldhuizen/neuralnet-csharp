using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuralNetworking;
using System.Linq;

namespace NeuralNetworkTests
{
    [TestClass]
    public class NeuralNetworkTests
    {
        //INeuralNetwork network;
		NeuronCount expectedInputNeurons = 1;
		NeuronCount[] expectedNeuronsPerHiddenLayer = new NeuronCount[] { 2, 3 };
		NeuronCount expectedOutputNeurons = 4;

        [TestInitialize]
        public void Initialize()
        {
            //network = new NeuralNetwork(expectedInputNeurons, expectedNeuronsPerHiddenLayer, expectedOutputNeurons);
        }

		[TestMethod, ExpectedException(typeof(ArgumentException))]
		public void needs_at_least_one_input() =>
			new NeuralNetwork(0, expectedNeuronsPerHiddenLayer, expectedOutputNeurons);

		/*
        [TestMethod]
        public void has_four_layers() =>
            Assert.AreEqual(4, network.Layers.Length);
*/
	}
}
