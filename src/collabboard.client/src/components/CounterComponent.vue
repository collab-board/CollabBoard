<template>
  <div>
    Test Demo
    <div @click="addCount">
      {{ count }}
    </div>
  </div>
</template>

<script setup lang="ts">
import { ref } from "vue";

const count = ref(0);

function addCount() {
  count.value++;
}
</script>
