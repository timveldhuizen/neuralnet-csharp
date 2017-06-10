using System;
using System.Linq;

namespace NeuralNetworking
{
	public partial class NeuralNetwork
	{
		class NeuralNetworkLayer : INeuralNetworkLayer
		{
			Neuron[] neurons;

			public NeuralNetworkLayer(NeuronCount numberOfNeurons)
			{
				neurons = Enumerable.Range(1, numberOfNeurons)
					.Select(_ => new Neuron())
					.ToArray();
			}

			void INeuralNetworkLayer.BuildSynapses(INeuralNetworkLayer previousLayer)
			{
				throw new NotImplementedException();
			}
		}
	}
}