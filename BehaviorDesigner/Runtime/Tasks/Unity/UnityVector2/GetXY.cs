using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x0200131D RID: 4893
	[Token(Token = "0x2000CE9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C820", Offset = "0x14C921")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C820", Offset = "0x14C921")]
	public class GetXY : Action
	{
		// Token: 0x06007365 RID: 29541 RVA: 0x00027D50 File Offset: 0x00025F50
		[Token(Token = "0x6006019")]
		[Address(RVA = "0x29A0630", Offset = "0x29A0731", VA = "0x29A0630", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600601A")]
		[Address(RVA = "0x29A06E0", Offset = "0x29A07E1", VA = "0x29A06E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600601B")]
		[Address(RVA = "0x29A0790", Offset = "0x29A0891", VA = "0x29A0790")]
		public GetXY()
		{
		}

		// Token: 0x0401B649 RID: 112201
		[Token(Token = "0x401806E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184E20", Offset = "0x184F21")]
		public SharedVector2 vector2Variable;

		// Token: 0x0401B64A RID: 112202
		[Token(Token = "0x401806F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184E60", Offset = "0x184F61")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184E60", Offset = "0x184F61")]
		public SharedFloat storeX;

		// Token: 0x0401B64B RID: 112203
		[Token(Token = "0x4018070")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184EB0", Offset = "0x184FB1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184EB0", Offset = "0x184FB1")]
		public SharedFloat storeY;
	}
}
