<?php

/* @Twig/layout.html.twig */
class __TwigTemplate_ac4577b33a1508f28febae67b77f8b093663a6c91b13d448e6865acd42e10dd8 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_6ab02200957aa65458e7aa177a16144d758e6c646b23c746937983bb961ebece = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6ab02200957aa65458e7aa177a16144d758e6c646b23c746937983bb961ebece->enter($__internal_6ab02200957aa65458e7aa177a16144d758e6c646b23c746937983bb961ebece_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_b1d947cb58cbead7eb7611a3b16f6af1505b21fdc638514bbc2b2adf3f882861 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b1d947cb58cbead7eb7611a3b16f6af1505b21fdc638514bbc2b2adf3f882861->enter($__internal_b1d947cb58cbead7eb7611a3b16f6af1505b21fdc638514bbc2b2adf3f882861_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"";
        // line 4
        echo twig_escape_filter($this->env, $this->env->getCharset(), "html", null, true);
        echo "\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>";
        // line 7
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
        <link rel=\"icon\" type=\"image/png\" href=\"";
        // line 8
        echo twig_include($this->env, $context, "@Twig/images/favicon.png.base64");
        echo "\">
        <style>";
        // line 9
        echo twig_include($this->env, $context, "@Twig/exception.css.twig");
        echo "</style>
        ";
        // line 10
        $this->displayBlock('head', $context, $blocks);
        // line 11
        echo "    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">";
        // line 15
        echo twig_include($this->env, $context, "@Twig/images/symfony-logo.svg");
        echo " Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">";
        // line 19
        echo twig_include($this->env, $context, "@Twig/images/icon-book.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">";
        // line 26
        echo twig_include($this->env, $context, "@Twig/images/icon-support.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        ";
        // line 33
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        ";
        echo twig_include($this->env, $context, "@Twig/base_js.html.twig");
        echo "
    </body>
</html>
";
        
        $__internal_6ab02200957aa65458e7aa177a16144d758e6c646b23c746937983bb961ebece->leave($__internal_6ab02200957aa65458e7aa177a16144d758e6c646b23c746937983bb961ebece_prof);

        
        $__internal_b1d947cb58cbead7eb7611a3b16f6af1505b21fdc638514bbc2b2adf3f882861->leave($__internal_b1d947cb58cbead7eb7611a3b16f6af1505b21fdc638514bbc2b2adf3f882861_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_dcd01808f3880288bc07f0c98b88112acd19eb1a70f2544454031b2a5e8c0d0a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_dcd01808f3880288bc07f0c98b88112acd19eb1a70f2544454031b2a5e8c0d0a->enter($__internal_dcd01808f3880288bc07f0c98b88112acd19eb1a70f2544454031b2a5e8c0d0a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_eb6645defc8b5fc10a01598998aa8d2b4c46c32b8550f4100844f62e3be20fca = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_eb6645defc8b5fc10a01598998aa8d2b4c46c32b8550f4100844f62e3be20fca->enter($__internal_eb6645defc8b5fc10a01598998aa8d2b4c46c32b8550f4100844f62e3be20fca_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_eb6645defc8b5fc10a01598998aa8d2b4c46c32b8550f4100844f62e3be20fca->leave($__internal_eb6645defc8b5fc10a01598998aa8d2b4c46c32b8550f4100844f62e3be20fca_prof);

        
        $__internal_dcd01808f3880288bc07f0c98b88112acd19eb1a70f2544454031b2a5e8c0d0a->leave($__internal_dcd01808f3880288bc07f0c98b88112acd19eb1a70f2544454031b2a5e8c0d0a_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_eb26476b752894fc9b62a932ddaedf4737d172c290a55794abcb3d71d6069ca5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_eb26476b752894fc9b62a932ddaedf4737d172c290a55794abcb3d71d6069ca5->enter($__internal_eb26476b752894fc9b62a932ddaedf4737d172c290a55794abcb3d71d6069ca5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_3e286a46732c9c045be99e373ff2e33279abf0c47fd63f01d3d3261c9f3d2f3b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3e286a46732c9c045be99e373ff2e33279abf0c47fd63f01d3d3261c9f3d2f3b->enter($__internal_3e286a46732c9c045be99e373ff2e33279abf0c47fd63f01d3d3261c9f3d2f3b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_3e286a46732c9c045be99e373ff2e33279abf0c47fd63f01d3d3261c9f3d2f3b->leave($__internal_3e286a46732c9c045be99e373ff2e33279abf0c47fd63f01d3d3261c9f3d2f3b_prof);

        
        $__internal_eb26476b752894fc9b62a932ddaedf4737d172c290a55794abcb3d71d6069ca5->leave($__internal_eb26476b752894fc9b62a932ddaedf4737d172c290a55794abcb3d71d6069ca5_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_9d8641aafc3e105352a3ee13dcdefa7397c27fa2493951d77dfefb63dadac9f8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9d8641aafc3e105352a3ee13dcdefa7397c27fa2493951d77dfefb63dadac9f8->enter($__internal_9d8641aafc3e105352a3ee13dcdefa7397c27fa2493951d77dfefb63dadac9f8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_dfc990d3d5220e8de119cd2e37b70e6394f2fb0db8a6c8e1d2af03a98f45f22c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_dfc990d3d5220e8de119cd2e37b70e6394f2fb0db8a6c8e1d2af03a98f45f22c->enter($__internal_dfc990d3d5220e8de119cd2e37b70e6394f2fb0db8a6c8e1d2af03a98f45f22c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_dfc990d3d5220e8de119cd2e37b70e6394f2fb0db8a6c8e1d2af03a98f45f22c->leave($__internal_dfc990d3d5220e8de119cd2e37b70e6394f2fb0db8a6c8e1d2af03a98f45f22c_prof);

        
        $__internal_9d8641aafc3e105352a3ee13dcdefa7397c27fa2493951d77dfefb63dadac9f8->leave($__internal_9d8641aafc3e105352a3ee13dcdefa7397c27fa2493951d77dfefb63dadac9f8_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  137 => 33,  120 => 10,  103 => 7,  88 => 34,  86 => 33,  76 => 26,  66 => 19,  59 => 15,  53 => 11,  51 => 10,  47 => 9,  43 => 8,  39 => 7,  33 => 4,  28 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"{{ _charset }}\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>{% block title %}{% endblock %}</title>
        <link rel=\"icon\" type=\"image/png\" href=\"{{ include('@Twig/images/favicon.png.base64') }}\">
        <style>{{ include('@Twig/exception.css.twig') }}</style>
        {% block head %}{% endblock %}
    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">{{ include('@Twig/images/symfony-logo.svg') }} Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-book.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-support.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        {% block body %}{% endblock %}
        {{ include('@Twig/base_js.html.twig') }}
    </body>
</html>
", "@Twig/layout.html.twig", "C:\\Projects\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}
