using System;


namespace R5T.E0062
{
	public class Try : ITry
	{
		#region Infrastructure

	    public static ITry Instance { get; } = new Try();

	    private Try()
	    {
        }

	    #endregion
	}
}