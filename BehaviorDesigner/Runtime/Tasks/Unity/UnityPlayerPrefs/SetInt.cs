using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013D3 RID: 5075
	[Token(Token = "0x2000D9E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150C50", Offset = "0x150D51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150C50", Offset = "0x150D51")]
	public class SetInt : Action
	{
		// Token: 0x060075ED RID: 30189 RVA: 0x00028E48 File Offset: 0x00027048
		[Token(Token = "0x60062A1")]
		[Address(RVA = "0x298E060", Offset = "0x298E161", VA = "0x298E060", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A2")]
		[Address(RVA = "0x298E0F0", Offset = "0x298E1F1", VA = "0x298E0F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A3")]
		[Address(RVA = "0x298E170", Offset = "0x298E271", VA = "0x298E170")]
		public SetInt()
		{
		}

		// Token: 0x0401B8A4 RID: 112804
		[Token(Token = "0x40182C5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B470", Offset = "0x18B571")]
		public SharedString key;

		// Token: 0x0401B8A5 RID: 112805
		[Token(Token = "0x40182C6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B4B0", Offset = "0x18B5B1")]
		public SharedInt value;
	}
}
