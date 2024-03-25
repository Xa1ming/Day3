<template>
    <h3>编辑页面</h3>
</template>
<script setup lang="ts">
import { useRoute } from "vue-router";

const route = useRoute();
alert(route.query.Id);
</script>