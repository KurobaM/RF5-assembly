using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C8 RID: 5064
	[Token(Token = "0x2000D93")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150830", Offset = "0x150931")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150830", Offset = "0x150931")]
	public class LookRotation : Action
	{
		// Token: 0x060075CE RID: 30158 RVA: 0x00028D40 File Offset: 0x00026F40
		[Token(Token = "0x6006282")]
		[Address(RVA = "0x298F090", Offset = "0x298F191", VA = "0x298F090", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006283")]
		[Address(RVA = "0x298F160", Offset = "0x298F261", VA = "0x298F160", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006284")]
		[Address(RVA = "0x298F220", Offset = "0x298F321", VA = "0x298F220")]
		public LookRotation()
		{
		}

		// Token: 0x0401B88C RID: 112780
		[Token(Token = "0x40182AD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AE10", Offset = "0x18AF11")]
		public SharedVector3 forwardVector;

		// Token: 0x0401B88D RID: 112781
		[Token(Token = "0x40182AE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AE50", Offset = "0x18AF51")]
		public SharedVector3 secondVector3;

		// Token: 0x0401B88E RID: 112782
		[Token(Token = "0x40182AF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AE90", Offset = "0x18AF91")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18AE90", Offset = "0x18AF91")]
		public SharedQuaternion storeResult;
	}
}
