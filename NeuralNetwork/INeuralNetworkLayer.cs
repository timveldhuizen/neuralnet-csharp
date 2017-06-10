using System.Collections.Generic;

namespace NeuralNetworking
{
	public interface INeuralNetworkLayer
	{
		void BuildSynapses(INeuralNetworkLayer previousLayer);
	}
}