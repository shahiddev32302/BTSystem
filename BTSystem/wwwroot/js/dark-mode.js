// Initialize dark mode
;(function initDarkMode() {
  const theme = localStorage.getItem("theme") || "light"
  document.documentElement.setAttribute("data-theme", theme)
})()

// Dark mode toggle
document.addEventListener("DOMContentLoaded", () => {
  const toggle = document.getElementById("darkModeToggle")
  if (toggle) {
    toggle.addEventListener("click", () => {
      const currentTheme = document.documentElement.getAttribute("data-theme")
      const newTheme = currentTheme === "dark" ? "light" : "dark"

      document.documentElement.setAttribute("data-theme", newTheme)
      localStorage.setItem("theme", newTheme)

      // Update icon
      const icon = toggle.querySelector("i")
      if (newTheme === "dark") {
        icon.classList.remove("fa-moon")
        icon.classList.add("fa-sun")
      } else {
        icon.classList.add("fa-moon")
        icon.classList.remove("fa-sun")
      }
    })

    // Set initial icon
    const currentTheme = document.documentElement.getAttribute("data-theme")
    const icon = toggle.querySelector("i")
    if (currentTheme === "dark") {
      icon.classList.add("fa-sun")
    }
  }
})
