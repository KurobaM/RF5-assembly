using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTime
{
	// Token: 0x0200134F RID: 4943
	[Token(Token = "0x2000D1A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DA80", Offset = "0x14DB81")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DA80", Offset = "0x14DB81")]
	public class SetTimeScale : Action
	{
		// Token: 0x0600741D RID: 29725 RVA: 0x000281E8 File Offset: 0x000263E8
		[Token(Token = "0x60060D1")]
		[Address(RVA = "0x299A740", Offset = "0x299A841", VA = "0x299A740", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D2")]
		[Address(RVA = "0x299A7B0", Offset = "0x299A8B1", VA = "0x299A7B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D3")]
		[Address(RVA = "0x299A810", Offset = "0x299A911", VA = "0x299A810")]
		public SetTimeScale()
		{
		}

		// Token: 0x0401B708 RID: 112392
		[Token(Token = "0x4018129")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186B30", Offset = "0x186C31")]
		public SharedFloat timeScale;
	}
}
