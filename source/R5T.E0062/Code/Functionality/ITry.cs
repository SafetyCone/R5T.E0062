using System;
using System.Threading.Tasks;

using R5T.F0033;
using R5T.F0079;
using R5T.T0132;
using R5T.Z0021;

using R5T.E0062.R001;


namespace R5T.E0062
{
	[FunctionalityMarker]
	public partial interface ITry : IFunctionalityMarker
	{
		public async Task GenerateProgramFile()
		{
			var code = await ComponentOperator.Instance.NewRenderer<ProgramFile>()
				.SetParameter(c => c.NamespaceName, "Namespace01")
				.Render();

			var codeFilePath = CodeFilePathOperator.Instance.GetTemporaryCodeFilePath("Program");

			NotepadPlusPlusOperator.Instance.WriteTextAndOpen(
				codeFilePath,
				code);
		}
	}
}