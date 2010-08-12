

namespace MCloud.Provider.Model
{

	/// <summary>
	/// Various states that a node can be in.
	/// </summary>
	public enum NodeState {
		Running,
		Rebooting,
		Terminated,
		Pending,
		Unknown
	}
}

