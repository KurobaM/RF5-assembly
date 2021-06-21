using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001352 RID: 4946
	[Token(Token = "0x2000D1D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DBA0", Offset = "0x14DCA1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DBA0", Offset = "0x14DCA1")]
	public class Format : Action
	{
		// Token: 0x06007426 RID: 29734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DA")]
		[Address(RVA = "0x2999910", Offset = "0x2999A11", VA = "0x2999910", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x00028230 File Offset: 0x00026430
		[Token(Token = "0x60060DB")]
		[Address(RVA = "0x2999980", Offset = "0x2999A81", VA = "0x2999980", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DC")]
		[Address(RVA = "0x2999BC0", Offset = "0x2999CC1", VA = "0x2999BC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DD")]
		[Address(RVA = "0x2999C40", Offset = "0x2999D41", VA = "0x2999C40")]
		public Format()
		{
		}

		// Token: 0x0401B70E RID: 112398
		[Token(Token = "0x401812F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186CD0", Offset = "0x186DD1")]
		public SharedString format;

		// Token: 0x0401B70F RID: 112399
		[Token(Token = "0x4018130")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186D10", Offset = "0x186E11")]
		public SharedGenericVariable[] variables;

		// Token: 0x0401B710 RID: 112400
		[Token(Token = "0x4018131")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186D50", Offset = "0x186E51")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x186D50", Offset = "0x186E51")]
		public SharedString storeResult;

		// Token: 0x0401B711 RID: 112401
		[Token(Token = "0x4018132")]
		[FieldOffset(Offset = "0x68")]
		private object[] variableValues;
	}
}
