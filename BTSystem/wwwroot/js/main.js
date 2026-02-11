// Global utilities and functions

// Toast notification system
class Toast {
  static show(message, type = "info", duration = 3000) {
    const toastContainer = document.getElementById("toastContainer") || this.createContainer()

    const toast = document.createElement("div")
    toast.className = `alert alert-${type} alert-dismissible fade show`
    toast.style.marginBottom = "var(--spacing-lg)"
    toast.innerHTML = `
            ${message}
            <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
        `

    toastContainer.appendChild(toast)

    if (duration > 0) {
      setTimeout(() => toast.remove(), duration)
    }
  }

  static createContainer() {
    const container = document.createElement("div")
    container.id = "toastContainer"
    container.style.position = "fixed"
    container.style.top = "var(--spacing-lg)"
    container.style.right = "var(--spacing-lg)"
    container.style.zIndex = "9999"
    container.style.maxWidth = "400px"
    document.body.appendChild(container)
    return container
  }

  static success(message) {
    this.show(message, "success")
  }

  static error(message) {
    this.show(message, "danger")
  }

  static warning(message) {
    this.show(message, "warning")
  }
}

// Utility functions
const Utils = {
  formatDate: (date) => new Date(date).toLocaleDateString(),
  formatTime: (date) => new Date(date).toLocaleTimeString(),
  debounce: (func, delay) => {
    let timeoutId
    return function (...args) {
      clearTimeout(timeoutId)
      timeoutId = setTimeout(() => func.apply(this, args), delay)
    }
  },
  throttle: (func, delay) => {
    let lastCall = 0
    return function (...args) {
      const now = Date.now()
      if (now - lastCall >= delay) {
        func.apply(this, args)
        lastCall = now
      }
    }
  },
}

// Export for use in other files
window.Toast = Toast
window.Utils = Utils
