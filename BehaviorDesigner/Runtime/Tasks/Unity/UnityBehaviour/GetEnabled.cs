using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBehaviour
{
	// Token: 0x0200147A RID: 5242
	[Token(Token = "0x2000E40")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154910", Offset = "0x154A11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154910", Offset = "0x154A11")]
	public class GetEnabled : Action
	{
		// Token: 0x06007836 RID: 30774 RVA: 0x00029D90 File Offset: 0x00027F90
		[Token(Token = "0x60064EA")]
		[Address(RVA = "0x28DED20", Offset = "0x28DEE21", VA = "0x28DED20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EB")]
		[Address(RVA = "0x28DEDF0", Offset = "0x28DEEF1", VA = "0x28DEDF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EC")]
		[Address(RVA = "0x28DEE70", Offset = "0x28DEF71", VA = "0x28DEE70")]
		public GetEnabled()
		{
		}

		// Token: 0x0401BAF3 RID: 113395
		[Token(Token = "0x40184F1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1912A0", Offset = "0x1913A1")]
		public SharedBehaviour specifiedObject;

		// Token: 0x0401BAF4 RID: 113396
		[Token(Token = "0x40184F2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1912E0", Offset = "0x1913E1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1912E0", Offset = "0x1913E1")]
		public SharedBool storeValue;
	}
}
