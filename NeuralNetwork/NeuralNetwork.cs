using System;
using System.Linq;

namespace NeuralNetworking
{
	public class NeuronCount
	{
		int value;

		public static implicit operator NeuronCount(int value) =>
			new NeuronCount(value);

		public static implicit operator int(NeuronCount neuronCount) =>
			neuronCount.value;

		public NeuronCount(int value)
		{
			if (value < 1)
				throw new ArgumentException("Neuron count cannot be less than 1", nameof(value));
			this.value = value;
		}
	}

    public partial class NeuralNetwork: INeuralNetwork
    {
        INeuralNetworkLayer[] INeuralNetwork.Layers => layers;

        NeuralNetworkLayer[] layers;

        public NeuralNetwork(NeuronCount inputs, NeuronCount[] numberOfNeuronsPerHiddenLayer, NeuronCount outputs)
        {
			layers = new[] { inputs }
				.Concat(numberOfNeuronsPerHiddenLayer)
				.Concat(new[] { outputs })
				.Select(n => new NeuralNetworkLayer(n))
				.ToArray();

			for (var i = layers.Length - 1; i > 1; i--)
				((INeuralNetworkLayer)layers[i]).BuildSynapses(layers[i - 1]);
        }
    }
}