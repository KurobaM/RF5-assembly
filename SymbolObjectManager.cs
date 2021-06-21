using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020008B2 RID: 2226
[Token(Token = "0x20005C6")]
public class SymbolObjectManager : SingletonMonoBehaviour<SymbolObjectManager>
{
	// Token: 0x06003B11 RID: 15121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600317D")]
	[Address(RVA = "0x1FADF00", Offset = "0x1FAE001", VA = "0x1FADF00")]
	private void Start()
	{
	}

	// Token: 0x06003B12 RID: 15122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600317E")]
	[Address(RVA = "0x1FAE0E0", Offset = "0x1FAE1E1", VA = "0x1FAE0E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06003B13 RID: 15123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600317F")]
	[Address(RVA = "0x1FB1750", Offset = "0x1FB1851", VA = "0x1FB1750")]
	private void OnDestroy()
	{
	}

	// Token: 0x06003B14 RID: 15124 RVA: 0x00014B20 File Offset: 0x00012D20
	[Token(Token = "0x6003180")]
	[Address(RVA = "0x1FAEFD0", Offset = "0x1FAF0D1", VA = "0x1FAEFD0")]
	private bool IsLoading()
	{
		return default(bool);
	}

	// Token: 0x06003B15 RID: 15125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003181")]
	[Address(RVA = "0x1FB0420", Offset = "0x1FB0521", VA = "0x1FB0420")]
	private void CreateFocusSymbolObject(SymbolObjectManager.SymbolObject _symbol)
	{
	}

	// Token: 0x06003B16 RID: 15126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003182")]
	[Address(RVA = "0x1FB0BF0", Offset = "0x1FB0CF1", VA = "0x1FB0BF0")]
	private void CreateFieldSymbolObject(SymbolObjectManager.SymbolObject _symbol)
	{
	}

	// Token: 0x06003B17 RID: 15127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003183")]
	[Address(RVA = "0x1FB12A0", Offset = "0x1FB13A1", VA = "0x1FB12A0")]
	private void UpdateSymbolObject(SymbolObjectManager.SymbolObject _symbol)
	{
	}

	// Token: 0x06003B18 RID: 15128 RVA: 0x00014B38 File Offset: 0x00012D38
	[Token(Token = "0x6003184")]
	[Address(RVA = "0x1FB1550", Offset = "0x1FB1651", VA = "0x1FB1550")]
	private bool IsCropHarvest(SymbolObjectManager.SymbolObject _symbol)
	{
		return default(bool);
	}

	// Token: 0x06003B19 RID: 15129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003185")]
	[Address(RVA = "0x1FB17E0", Offset = "0x1FB18E1", VA = "0x1FB17E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A6400", Offset = "0x1A6501")]
	private IEnumerator CreateSymbolAnimation(SymbolObjectManager.SymbolObject _symbol)
	{
		return null;
	}

	// Token: 0x06003B1A RID: 15130 RVA: 0x00014B50 File Offset: 0x00012D50
	[Token(Token = "0x6003186")]
	[Address(RVA = "0x1FB1220", Offset = "0x1FB1321", VA = "0x1FB1220")]
	private bool IsSymbolObjectExist()
	{
		return default(bool);
	}

	// Token: 0x06003B1B RID: 15131 RVA: 0x00014B68 File Offset: 0x00012D68
	[Token(Token = "0x6003187")]
	[Address(RVA = "0x1FAF2F0", Offset = "0x1FAF3F1", VA = "0x1FAF2F0")]
	private bool CanInteraction(FocusInterface _target)
	{
		return default(bool);
	}

	// Token: 0x06003B1C RID: 15132 RVA: 0x00014B80 File Offset: 0x00012D80
	[Token(Token = "0x6003188")]
	[Address(RVA = "0x1FAF710", Offset = "0x1FAF811", VA = "0x1FAF710")]
	private SymbolObjectManager.SymbolObjectType GetSymbolObjectType(FocusInterface _target)
	{
		return SymbolObjectManager.SymbolObjectType.None;
	}

	// Token: 0x06003B1D RID: 15133 RVA: 0x00014B98 File Offset: 0x00012D98
	[Token(Token = "0x6003189")]
	[Address(RVA = "0x1FB0140", Offset = "0x1FB0241", VA = "0x1FB0140")]
	private float GetSymbolOffest(GameObject _object, Collider _collider)
	{
		return 0f;
	}

	// Token: 0x06003B1E RID: 15134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600318A")]
	[Address(RVA = "0x1FAFFD0", Offset = "0x1FB00D1", VA = "0x1FAFFD0")]
	private GameObject GetTargetEffectPos(GameObject _object)
	{
		return null;
	}

	// Token: 0x06003B1F RID: 15135 RVA: 0x00014BB0 File Offset: 0x00012DB0
	[Token(Token = "0x600318B")]
	[Address(RVA = "0x1FB0860", Offset = "0x1FB0961", VA = "0x1FB0860")]
	private bool IsFieldObjectFocused()
	{
		return default(bool);
	}

	// Token: 0x06003B20 RID: 15136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318C")]
	[Address(RVA = "0x1FAF0C0", Offset = "0x1FAF1C1", VA = "0x1FAF0C0")]
	private void ClearFocusSymbolObject()
	{
	}

	// Token: 0x06003B21 RID: 15137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318D")]
	[Address(RVA = "0x1FB0A90", Offset = "0x1FB0B91", VA = "0x1FB0A90")]
	private void ClearFieldSymbolObject(int _index)
	{
	}

	// Token: 0x06003B22 RID: 15138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318E")]
	[Address(RVA = "0x1FAF190", Offset = "0x1FAF291", VA = "0x1FAF190")]
	private void ClearAllFieldSymbolObject()
	{
	}

	// Token: 0x06003B23 RID: 15139 RVA: 0x00014BC8 File Offset: 0x00012DC8
	[Token(Token = "0x600318F")]
	[Address(RVA = "0x1FAD8B0", Offset = "0x1FAD9B1", VA = "0x1FAD8B0")]
	public bool IsFocusSymbolTarget(FocusInterface _target)
	{
		return default(bool);
	}

	// Token: 0x06003B24 RID: 15140 RVA: 0x00014BE0 File Offset: 0x00012DE0
	[Token(Token = "0x6003190")]
	[Address(RVA = "0x1FADA40", Offset = "0x1FADB41", VA = "0x1FADA40")]
	public bool IsFieldSymbolTarget(FocusInterface _target)
	{
		return default(bool);
	}

	// Token: 0x06003B25 RID: 15141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003191")]
	[Address(RVA = "0x1FB18B0", Offset = "0x1FB19B1", VA = "0x1FB18B0")]
	public SymbolObjectManager()
	{
	}

	// Token: 0x06003B26 RID: 15142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003192")]
	[Address(RVA = "0x1FB19F0", Offset = "0x1FB1AF1", VA = "0x1FB19F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6470", Offset = "0x1A6571")]
	private void <Start>b__26_0(AssetHandle<GameObject> _handle)
	{
	}

	// Token: 0x06003B27 RID: 15143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003193")]
	[Address(RVA = "0x1FB1A70", Offset = "0x1FB1B71", VA = "0x1FB1A70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6480", Offset = "0x1A6581")]
	private void <Start>b__26_1(AssetHandle<GameObject> _handle)
	{
	}

	// Token: 0x06003B28 RID: 15144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003194")]
	[Address(RVA = "0x1FB1AF0", Offset = "0x1FB1BF1", VA = "0x1FB1AF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6490", Offset = "0x1A6591")]
	private void <Start>b__26_2(AssetHandle<GameObject> _handle)
	{
	}

	// Token: 0x06003B29 RID: 15145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003195")]
	[Address(RVA = "0x1FB1B80", Offset = "0x1FB1C81", VA = "0x1FB1B80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A64A0", Offset = "0x1A65A1")]
	private void <Start>b__26_3()
	{
	}

	// Token: 0x04007DCF RID: 32207
	[Token(Token = "0x40071BC")]
	[FieldOffset(Offset = "0x18")]
	private FocusInterface focusObject;

	// Token: 0x04007DD0 RID: 32208
	[Token(Token = "0x40071BD")]
	[FieldOffset(Offset = "0x20")]
	private FocusInterface[] fieldObject;

	// Token: 0x04007DD1 RID: 32209
	[Token(Token = "0x40071BE")]
	private const int FIELD_FOCUS_MAX = 10;

	// Token: 0x04007DD2 RID: 32210
	[Token(Token = "0x40071BF")]
	[FieldOffset(Offset = "0x28")]
	private SymbolObjectManager.SymbolObject currentFocusSymbol;

	// Token: 0x04007DD3 RID: 32211
	[Token(Token = "0x40071C0")]
	[FieldOffset(Offset = "0x30")]
	private SymbolObjectManager.SymbolObject[] currentFieldSymbol;

	// Token: 0x04007DD4 RID: 32212
	[Token(Token = "0x40071C1")]
	[FieldOffset(Offset = "0x38")]
	private GameObject redTriangle;

	// Token: 0x04007DD5 RID: 32213
	[Token(Token = "0x40071C2")]
	[FieldOffset(Offset = "0x40")]
	private readonly int RED_TRIANGLE_ID;

	// Token: 0x04007DD6 RID: 32214
	[Token(Token = "0x40071C3")]
	[FieldOffset(Offset = "0x48")]
	private GameObject blueTriangle;

	// Token: 0x04007DD7 RID: 32215
	[Token(Token = "0x40071C4")]
	[FieldOffset(Offset = "0x50")]
	private readonly int BLUE_TRIANGLE_ID;

	// Token: 0x04007DD8 RID: 32216
	[Token(Token = "0x40071C5")]
	[FieldOffset(Offset = "0x58")]
	private SpriteSymbolObject spriteSymbolObject;

	// Token: 0x04007DD9 RID: 32217
	[Token(Token = "0x40071C6")]
	[FieldOffset(Offset = "0x60")]
	private readonly int SPRITE_ACCESSSYMBOL_ID;

	// Token: 0x04007DDA RID: 32218
	[Token(Token = "0x40071C7")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Sprite> iconBorder;

	// Token: 0x04007DDB RID: 32219
	[Token(Token = "0x40071C8")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<Sprite> iconSprite;

	// Token: 0x04007DDC RID: 32220
	[Token(Token = "0x40071C9")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private SpriteRenderer orderBoardSprite;

	// Token: 0x04007DDD RID: 32221
	[Token(Token = "0x40071CA")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float symbolOffset;

	// Token: 0x04007DDE RID: 32222
	[Token(Token = "0x40071CB")]
	[FieldOffset(Offset = "0x84")]
	private float curveRate;

	// Token: 0x04007DDF RID: 32223
	[Token(Token = "0x40071CC")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AnimationCurve animCurve;

	// Token: 0x04007DE0 RID: 32224
	[Token(Token = "0x40071CD")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float curveSpeed;

	// Token: 0x04007DE1 RID: 32225
	[Token(Token = "0x40071CE")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	private float animHeight;

	// Token: 0x04007DE2 RID: 32226
	[Token(Token = "0x40071CF")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private float rotateSpeed;

	// Token: 0x04007DE3 RID: 32227
	[Token(Token = "0x40071D0")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private float startAnimSpeed;

	// Token: 0x04007DE4 RID: 32228
	[Token(Token = "0x40071D1")]
	[FieldOffset(Offset = "0xA0")]
	private bool isHold;

	// Token: 0x020008B3 RID: 2227
	[Token(Token = "0x200126F")]
	public class SymbolObject
	{
		// Token: 0x06003B2A RID: 15146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747B")]
		[Address(RVA = "0x1FB0410", Offset = "0x1FB0511", VA = "0x1FB0410")]
		public SymbolObject()
		{
		}

		// Token: 0x04007DE5 RID: 32229
		[Token(Token = "0x4019878")]
		[FieldOffset(Offset = "0x10")]
		public GameObject GameObject;

		// Token: 0x04007DE6 RID: 32230
		[Token(Token = "0x4019879")]
		[FieldOffset(Offset = "0x18")]
		public GameObject TargetObject;

		// Token: 0x04007DE7 RID: 32231
		[Token(Token = "0x401987A")]
		[FieldOffset(Offset = "0x20")]
		public bool IsFocusSymbol;

		// Token: 0x04007DE8 RID: 32232
		[Token(Token = "0x401987B")]
		[FieldOffset(Offset = "0x24")]
		public SymbolObjectManager.SymbolObjectType SymbolObjectType;

		// Token: 0x04007DE9 RID: 32233
		[Token(Token = "0x401987C")]
		[FieldOffset(Offset = "0x28")]
		public float Offset;
	}

	// Token: 0x020008B4 RID: 2228
	[Token(Token = "0x2001270")]
	public enum SymbolObjectType
	{
		// Token: 0x04007DEB RID: 32235
		[Token(Token = "0x401987E")]
		None,
		// Token: 0x04007DEC RID: 32236
		[Token(Token = "0x401987F")]
		TalkNpc,
		// Token: 0x04007DED RID: 32237
		[Token(Token = "0x4019880")]
		ShopPartnerNpc,
		// Token: 0x04007DEE RID: 32238
		[Token(Token = "0x4019881")]
		OrderNpc,
		// Token: 0x04007DEF RID: 32239
		[Token(Token = "0x4019882")]
		ScenarioNpc,
		// Token: 0x04007DF0 RID: 32240
		[Token(Token = "0x4019883")]
		NonGreetingNpc,
		// Token: 0x04007DF1 RID: 32241
		[Token(Token = "0x4019884")]
		ExclamNpc,
		// Token: 0x04007DF2 RID: 32242
		[Token(Token = "0x4019885")]
		EventNpc,
		// Token: 0x04007DF3 RID: 32243
		[Token(Token = "0x4019886")]
		HintBadgeNpc,
		// Token: 0x04007DF4 RID: 32244
		[Token(Token = "0x4019887")]
		WantedMonster,
		// Token: 0x04007DF5 RID: 32245
		[Token(Token = "0x4019888")]
		Crops,
		// Token: 0x04007DF6 RID: 32246
		[Token(Token = "0x4019889")]
		Farm,
		// Token: 0x04007DF7 RID: 32247
		[Token(Token = "0x401988A")]
		CanTalkMonster,
		// Token: 0x04007DF8 RID: 32248
		[Token(Token = "0x401988B")]
		Treasure,
		// Token: 0x04007DF9 RID: 32249
		[Token(Token = "0x401988C")]
		CanInteractObject,
		// Token: 0x04007DFA RID: 32250
		[Token(Token = "0x401988D")]
		CanDestoryObject,
		// Token: 0x04007DFB RID: 32251
		[Token(Token = "0x401988E")]
		CantDestoryObject,
		// Token: 0x04007DFC RID: 32252
		[Token(Token = "0x401988F")]
		Item,
		// Token: 0x04007DFD RID: 32253
		[Token(Token = "0x4019890")]
		OrderBoard,
		// Token: 0x04007DFE RID: 32254
		[Token(Token = "0x4019891")]
		DualSkill,
		// Token: 0x04007DFF RID: 32255
		[Token(Token = "0x4019892")]
		Door,
		// Token: 0x04007E00 RID: 32256
		[Token(Token = "0x4019893")]
		Pet
	}

	// Token: 0x020008B5 RID: 2229
	[Token(Token = "0x2001271")]
	private enum IconBorderType
	{
		// Token: 0x04007E02 RID: 32258
		[Token(Token = "0x4019895")]
		Purple,
		// Token: 0x04007E03 RID: 32259
		[Token(Token = "0x4019896")]
		White
	}

	// Token: 0x020008B6 RID: 2230
	[Token(Token = "0x2001272")]
	private enum IconSpriteType
	{
		// Token: 0x04007E05 RID: 32261
		[Token(Token = "0x4019898")]
		A_Btn,
		// Token: 0x04007E06 RID: 32262
		[Token(Token = "0x4019899")]
		B_Btn,
		// Token: 0x04007E07 RID: 32263
		[Token(Token = "0x401989A")]
		Order,
		// Token: 0x04007E08 RID: 32264
		[Token(Token = "0x401989B")]
		Scenario,
		// Token: 0x04007E09 RID: 32265
		[Token(Token = "0x401989C")]
		Event,
		// Token: 0x04007E0A RID: 32266
		[Token(Token = "0x401989D")]
		Wanted,
		// Token: 0x04007E0B RID: 32267
		[Token(Token = "0x401989E")]
		WantedFocus,
		// Token: 0x04007E0C RID: 32268
		[Token(Token = "0x401989F")]
		OrderBoard,
		// Token: 0x04007E0D RID: 32269
		[Token(Token = "0x40198A0")]
		DualSkill,
		// Token: 0x04007E0E RID: 32270
		[Token(Token = "0x40198A1")]
		Door,
		// Token: 0x04007E0F RID: 32271
		[Token(Token = "0x40198A2")]
		Pet
	}

	// Token: 0x020008B7 RID: 2231
	[Token(Token = "0x2001273")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D80", Offset = "0x158E81")]
	private sealed class <CreateSymbolAnimation>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003B2B RID: 15147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747C")]
		[Address(RVA = "0x1FB1880", Offset = "0x1FB1981", VA = "0x1FB1880")]
		[DebuggerHidden]
		public <CreateSymbolAnimation>d__34(int <>1__state)
		{
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747D")]
		[Address(RVA = "0x1FB1C00", Offset = "0x1FB1D01", VA = "0x1FB1C00", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x00014BF8 File Offset: 0x00012DF8
		[Token(Token = "0x600747E")]
		[Address(RVA = "0x1FB1C10", Offset = "0x1FB1D11", VA = "0x1FB1C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06003B2E RID: 15150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D78")]
		private object Current
		{
			[Token(Token = "0x600747F")]
			[Address(RVA = "0x1FB1F90", Offset = "0x1FB2091", VA = "0x1FB1F90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007480")]
		[Address(RVA = "0x1FB1FA0", Offset = "0x1FB20A1", VA = "0x1FB1FA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D79")]
		private object Current
		{
			[Token(Token = "0x6007481")]
			[Address(RVA = "0x1FB2000", Offset = "0x1FB2101", VA = "0x1FB2000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007E10 RID: 32272
		[Token(Token = "0x40198A3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007E11 RID: 32273
		[Token(Token = "0x40198A4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007E12 RID: 32274
		[Token(Token = "0x40198A5")]
		[FieldOffset(Offset = "0x20")]
		public SymbolObjectManager.SymbolObject _symbol;

		// Token: 0x04007E13 RID: 32275
		[Token(Token = "0x40198A6")]
		[FieldOffset(Offset = "0x28")]
		public SymbolObjectManager <>4__this;

		// Token: 0x04007E14 RID: 32276
		[Token(Token = "0x40198A7")]
		[FieldOffset(Offset = "0x30")]
		private float <rate>5__2;

		// Token: 0x04007E15 RID: 32277
		[Token(Token = "0x40198A8")]
		[FieldOffset(Offset = "0x34")]
		private float <scale>5__3;
	}
}
