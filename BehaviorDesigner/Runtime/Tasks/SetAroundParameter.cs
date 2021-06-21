using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012CB RID: 4811
	[Token(Token = "0x2000C98")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A870", Offset = "0x14A971")]
	public class SetAroundParameter : Action
	{
		// Token: 0x060071F5 RID: 29173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA9")]
		[Address(RVA = "0x221A460", Offset = "0x221A561", VA = "0x221A460", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAA")]
		[Address(RVA = "0x221A530", Offset = "0x221A631", VA = "0x221A530", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x00027288 File Offset: 0x00025488
		[Token(Token = "0x6005EAB")]
		[Address(RVA = "0x221A5D0", Offset = "0x221A6D1", VA = "0x221A5D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAC")]
		[Address(RVA = "0x221A9A0", Offset = "0x221AAA1", VA = "0x221A9A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAD")]
		[Address(RVA = "0x221A9B0", Offset = "0x221AAB1", VA = "0x221A9B0")]
		public SetAroundParameter()
		{
		}

		// Token: 0x0401B53C RID: 111932
		[Token(Token = "0x4017F65")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181D20", Offset = "0x181E21")]
		public SharedGameObject Target;

		// Token: 0x0401B53D RID: 111933
		[Token(Token = "0x4017F66")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181D60", Offset = "0x181E61")]
		public SharedFloat AroundRange;

		// Token: 0x0401B53E RID: 111934
		[Token(Token = "0x4017F67")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181DA0", Offset = "0x181EA1")]
		public SharedFloat AroundAngle;

		// Token: 0x0401B53F RID: 111935
		[Token(Token = "0x4017F68")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181DE0", Offset = "0x181EE1")]
		public SharedVector3 ReturnLookPosition;

		// Token: 0x0401B540 RID: 111936
		[Token(Token = "0x4017F69")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181E20", Offset = "0x181F21")]
		public SharedVector3List ReturnAroundPositionList;

		// Token: 0x0401B541 RID: 111937
		[Token(Token = "0x4017F6A")]
		[FieldOffset(Offset = "0x78")]
		private bool IsLeftRotate;

		// Token: 0x0401B542 RID: 111938
		[Token(Token = "0x4017F6B")]
		[FieldOffset(Offset = "0x7C")]
		private int AroundCount;

		// Token: 0x0401B543 RID: 111939
		[Token(Token = "0x4017F6C")]
		[FieldOffset(Offset = "0x80")]
		private MonsterActionInformation MonsterActionInformation;

		// Token: 0x0401B544 RID: 111940
		[Token(Token = "0x4017F6D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string AroundRangeKeyName;

		// Token: 0x0401B545 RID: 111941
		[Token(Token = "0x4017F6E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string AroundAngleKeyName;

		// Token: 0x0401B546 RID: 111942
		[Token(Token = "0x4017F6F")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string IsReleseEyesKeyName;

		// Token: 0x0401B547 RID: 111943
		[Token(Token = "0x4017F70")]
		[FieldOffset(Offset = "0x88")]
		private AIInput AIInput;
	}
}
