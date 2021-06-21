using System;
using System.Collections.Generic;
using BinaryStream;
using Define;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EC6 RID: 3782
	[Token(Token = "0x20009AE")]
	public class RF5EventData : SaveDataValueBase
	{
		// Token: 0x060062D4 RID: 25300 RVA: 0x000212B8 File Offset: 0x0001F4B8
		[Token(Token = "0x60051F3")]
		[Address(RVA = "0x1EFCAC0", Offset = "0x1EFCBC1", VA = "0x1EFCAC0")]
		public bool GetSaveGameFlag(GameFlagData id)
		{
			return default(bool);
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F4")]
		[Address(RVA = "0x1EFCB80", Offset = "0x1EFCC81", VA = "0x1EFCB80")]
		public void SetSaveGameFlag(int[] ids, bool value)
		{
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F5")]
		[Address(RVA = "0x1EFCC90", Offset = "0x1EFCD91", VA = "0x1EFCC90")]
		public RF5EventData()
		{
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F6")]
		[Address(RVA = "0x1EFCE00", Offset = "0x1EFCF01", VA = "0x1EFCE00", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F7")]
		[Address(RVA = "0x1EFD330", Offset = "0x1EFD431", VA = "0x1EFD330")]
		public void InitializeForNewGame()
		{
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F8")]
		[Address(RVA = "0x1EFD3F0", Offset = "0x1EFD4F1", VA = "0x1EFD3F0", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F9")]
		[Address(RVA = "0x1EFD530", Offset = "0x1EFD631", VA = "0x1EFD530", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FA")]
		[Address(RVA = "0x1EFD540", Offset = "0x1EFD641", VA = "0x1EFD540", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FB")]
		[Address(RVA = "0x1EFD980", Offset = "0x1EFDA81", VA = "0x1EFD980")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C2D0 RID: 49872
		[Token(Token = "0x40091FB")]
		[FieldOffset(Offset = "0x10")]
		public EventSaveParameter EventSaveParameter;

		// Token: 0x0400C2D1 RID: 49873
		[Token(Token = "0x40091FC")]
		[FieldOffset(Offset = "0x18")]
		public SaveFlagStorage SaveFlag;

		// Token: 0x0400C2D2 RID: 49874
		[Token(Token = "0x40091FD")]
		[FieldOffset(Offset = "0x20")]
		public SubEventSaveData SubEventSaveDatas;

		// Token: 0x0400C2D3 RID: 49875
		[Token(Token = "0x40091FE")]
		[FieldOffset(Offset = "0x28")]
		public int MainScenarioStep;

		// Token: 0x0400C2D4 RID: 49876
		[Token(Token = "0x40091FF")]
		[FieldOffset(Offset = "0x30")]
		public List<ActorID> PresentSendActorList;

		// Token: 0x0400C2D5 RID: 49877
		[Token(Token = "0x4009200")]
		[FieldOffset(Offset = "0x38")]
		public List<ActorID> PresentRecvActorList;

		// Token: 0x0400C2D6 RID: 49878
		[Token(Token = "0x4009201")]
		[FieldOffset(Offset = "0x40")]
		public bool IsStartFishing;

		// Token: 0x0400C2D7 RID: 49879
		[Token(Token = "0x4009202")]
		[FieldOffset(Offset = "0x48")]
		public List<ActorID> FesJoinActorList;

		// Token: 0x0400C2D8 RID: 49880
		[Token(Token = "0x4009203")]
		[FieldOffset(Offset = "0x50")]
		public List<ActorID> FesVisitorActorList;

		// Token: 0x0400C2D9 RID: 49881
		[Token(Token = "0x4009204")]
		[FieldOffset(Offset = "0x58")]
		public List<FesNpcScore> FesNpcScoreList;

		// Token: 0x0400C2DA RID: 49882
		[Token(Token = "0x4009205")]
		[FieldOffset(Offset = "0x60")]
		public int IsCalcFesId;

		// Token: 0x0400C2DB RID: 49883
		[Token(Token = "0x4009206")]
		[FieldOffset(Offset = "0x64")]
		public int VictoryCandidateNpcId;

		// Token: 0x0400C2DC RID: 49884
		[Token(Token = "0x4009207")]
		[FieldOffset(Offset = "0x68")]
		public int JudgeChildId;

		// Token: 0x0400C2DD RID: 49885
		[Token(Token = "0x4009208")]
		[FieldOffset(Offset = "0x70")]
		public List<int> FishTypeList;

		// Token: 0x0400C2DE RID: 49886
		[Token(Token = "0x4009209")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, int> FlagDataMappings;
	}
}
