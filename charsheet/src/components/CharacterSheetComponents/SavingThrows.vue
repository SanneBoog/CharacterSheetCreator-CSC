<template>
    <div>
      <h2>Savingthrows</h2>
        <p> Strength: {{ savingthrows.strength[1] }}</p><p v-if="savingThrows.strength[0] !== true">a</p>
        <p> Dexterity: {{ savingthrows.dexterity[1] }}</p><p v-if="savingThrows.dexterity[0] !== true">a</p>
        <p>Constitution: {{ savingthrows.constitution[1] }}</p>
        <p>Intelligence: {{ savingthrows.intelligence[1] }}</p>
        <p>Wisdom: {{ savingthrows.wisdom[1] }}</p>
        <p>Charisma: {{ savingthrows.charisma[1] }}</p>
    </div>
</template>
<script>
export default {
  name: 'SavingThrows',
  props: {
    proficiencyBonus: {
      type: Number,
      required: true,
    },
  },
  data() {
    return {
      savingthrows: {
        strength: [true, 10],
        dexterity: [false, 12],
        constitution: [false, 14],
        intelligence: [false, 16],
        wisdom: [false, 18],
        charisma: [false, 20],
      }
    }
  },
  computed: {
    savingThrow() {
      return this.savingthrows.strength[0] ? this.savingthrows.strength[1] + this.proficiencyBonus : this.savingthrows.strength[1]
    }
  }
}
</script>