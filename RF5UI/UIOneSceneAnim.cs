using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

namespace RF5UI
{
	// Token: 0x02000E9E RID: 3742
	[Token(Token = "0x2000996")]
	public class UIOneSceneAnim : MonoBehaviour
	{
		// Token: 0x060061DA RID: 25050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005108")]
		[Address(RVA = "0x1F33AF0", Offset = "0x1F33BF1", VA = "0x1F33AF0")]
		private void Start()
		{
		}

		// Token: 0x060061DB RID: 25051 RVA: 0x00020CD0 File Offset: 0x0001EED0
		[Token(Token = "0x6005109")]
		[Address(RVA = "0x1F33BC0", Offset = "0x1F33CC1", VA = "0x1F33BC0")]
		private float ReDalayEffectTime()
		{
			return 0f;
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510A")]
		[Address(RVA = "0x1F33BD0", Offset = "0x1F33CD1", VA = "0x1F33BD0")]
		private void Update()
		{
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510B")]
		[Address(RVA = "0x1F33E80", Offset = "0x1F33F81", VA = "0x1F33E80")]
		private static void Loaded(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510C")]
		[Address(RVA = "0x1F33F50", Offset = "0x1F34051", VA = "0x1F33F50")]
		public static void Call(UIOneSceneAnim.Type OpenType, [Optional] UnityAction _EndCallback)
		{
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510D")]
		[Address(RVA = "0x1F34140", Offset = "0x1F34241", VA = "0x1F34140")]
		public static void End()
		{
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510E")]
		[Address(RVA = "0x1F34210", Offset = "0x1F34311", VA = "0x1F34210")]
		private void OnDestroy()
		{
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510F")]
		[Address(RVA = "0x1F34370", Offset = "0x1F34471", VA = "0x1F34370")]
		public UIOneSceneAnim()
		{
		}

		// Token: 0x0400C194 RID: 49556
		[Token(Token = "0x4009121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UIOneSceneAnim.Type OpenType;

		// Token: 0x0400C195 RID: 49557
		[Token(Token = "0x4009122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] LoaderIDTable;

		// Token: 0x0400C196 RID: 49558
		[Token(Token = "0x4009123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform[] PrefEffectSpawnArea;

		// Token: 0x0400C197 RID: 49559
		[Token(Token = "0x4009124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIShopMoneyEffect UIShopMoneyEffect;

		// Token: 0x0400C198 RID: 49560
		[Token(Token = "0x4009125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<float> EffectSpawnDelayTimes;

		// Token: 0x0400C199 RID: 49561
		[Token(Token = "0x4009126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float SpawnDelayTimeRandMin;

		// Token: 0x0400C19A RID: 49562
		[Token(Token = "0x4009127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float SpawnDelayTimeRandMax;

		// Token: 0x0400C19B RID: 49563
		[Token(Token = "0x4009128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int loadingId;

		// Token: 0x0400C19C RID: 49564
		[Token(Token = "0x4009129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static UnityAction EndCallback;

		// Token: 0x0400C19D RID: 49565
		[Token(Token = "0x400912A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static GameObject usingAnim;

		// Token: 0x02000E9F RID: 3743
		[Token(Token = "0x2001474")]
		public enum Type
		{
			// Token: 0x0400C19F RID: 49567
			[Token(Token = "0x401BC80")]
			Rankup,
			// Token: 0x0400C1A0 RID: 49568
			[Token(Token = "0x401BC81")]
			GetBatch,
			// Token: 0x0400C1A1 RID: 49569
			[Token(Token = "0x401BC82")]
			WantedCleared,
			// Token: 0x0400C1A2 RID: 49570
			[Token(Token = "0x401BC83")]
			WantedCompleted,
			// Token: 0x0400C1A3 RID: 49571
			[Token(Token = "0x401BC84")]
			FarmDragon
		}
	}
}
